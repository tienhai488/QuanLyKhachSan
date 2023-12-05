using HotelManagement.BUS;
using HotelManagement.Business;
using HotelManagement.Data;
using HotelManagement.Data.Transfer;
using HotelManagement.Data.Transfer.Ultils;
using HotelManagement.Ultils;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Data;

namespace HotelManagement.GUI
{
    public partial class ReservBookingUI : MaterialForm
    {
        //Danh sach phong de hien thi khi dat
        private DataTable dataTableRoom = new DataTable();
        //Danh sach phong da duoc dat
        private DataTable dataTableBook = new DataTable();

        private RoomBUS roomBUS = new RoomBUS();
        private CustomerBUS customerBUS = new CustomerBUS();
        private ReservationBUS reservationBUS = new ReservationBUS();
        private RoomReservationBUS roomReservationBUS = new RoomReservationBUS();
        private Reservation reservationOld = null;

        ReservationUI reservationUI;

        private Staff staffLogin = LoginBO.SignedInStaff;
        public ReservBookingUI(ReservationUI reservationUI, string reservationId)
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Pink700,      // Main background color (Deeper Pink)
                Primary.Purple400,    // Darker background color
                Primary.Purple300,    // Slightly lighter accent background color
                Accent.Orange400,     // Warm accent color for highlights
                TextShade.WHITE       // Light text color for better readability
            );

            dataTableRoom.Columns.Add("ID");
            dataTableRoom.Columns.Add("Type");

            dataTableBook.Columns.Add("ID");
            dataTableBook.Columns.Add("Type");
            dataTableBook.Columns.Add("StartTime");
            dataTableBook.Columns.Add("EndTime");
            dataTableBook.Columns.Add("Status");

            txtId.Text = reservationId;

            labelDontExist.Visible = false;

            this.reservationUI = reservationUI;

            this.reservationOld = reservationBUS.getById(reservationId);

            initTableBookedByReservationId(reservationId);

            initTableRoom(fromTime.Value, toTime.Value);

            fillDataCustomerByReservation(this.reservationOld);
        }

        #region method
        public void fillDataCustomerByReservation(Reservation reservation)
        {
            if (reservation != null)
            {
                fillDataCustomer(this.reservationOld.Customer);
            }
        }

        public void addColumnAction(DataGridView dtgv, string text, DataTable dataTable)
        {
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.HeaderText = "Action";
            buttonColumn.Text = text;
            buttonColumn.UseColumnTextForButtonValue = true;

            if (dataTable.Columns.Count != dtgv.Columns.Count)
                return;
            dtgv.Columns.Add(buttonColumn);
        }

        public void removeItemInDataTableRoom(DateTime from, DateTime to)
        {
            foreach (DataRow item in dataTableBook.Rows)
            {
                var statusEnum = RoomReservation.getStatusEnum(item[4].ToString());
                if (RoomReservationStatus.OutDate != statusEnum && RoomReservationStatus.Paid != statusEnum)
                {
                    DateTime fromTimeBook = Functions.convertStringToDateTime(item[2].ToString());
                    DateTime toTimeBook = Functions.convertStringToDateTime(item[3].ToString());

                    bool checkInRange = (Functions.getDayGap(from, fromTimeBook) >= 0 && Functions.getDayGap(fromTimeBook, to) >= 0) ||
                    (Functions.getDayGap(from, toTimeBook) >= 0 && Functions.getDayGap(toTimeBook, to) >= 0);

                    if (checkInRange)
                    {
                        string id = item[0].ToString();

                        foreach (DataRow row in dataTableRoom.Rows)
                        {
                            if (row[0].Equals(id))
                            {
                                dataTableRoom.Rows.Remove(row);
                                break;
                            }
                        }
                    }
                }
            }

            tableRoom.DataSource = null;
            tableRoom.DataSource = dataTableRoom;

        }


        public void initTableRoom(DateTime from, DateTime to)
        {
            dataTableRoom.Rows.Clear();
            tableRoom.DataSource = null;
            tableRoom.Columns.Clear();

            bool checkDateTime = Functions.getDayGap(DateTime.Now, from) >= 0 && Functions.getDayGap(from, to) >=0;

            if (checkDateTime)
            {
                this.reservationOld = reservationBUS.getById(txtId.Text);
                if (this.reservationOld == null)
                {
                    roomReservationBUS.getListRoomAllowBooking(from, to).ForEach(item => dataTableRoom.Rows.Add(item.Id, item.RoomType.Name));
                }
                else
                {
                    roomReservationBUS.getListRoomAllowBookingWithReservationId(from, to, this.reservationOld.Id).ForEach(item => dataTableRoom.Rows.Add(item.Id, item.RoomType.Name));
                }
            }

            removeItemInDataTableRoom(from, to);
            tableRoom.DataSource = dataTableRoom;

            addColumnAction(tableRoom, "Add", dataTableRoom);
        }

        public void initTableRoomEmpty()
        {
            dataTableRoom.Rows.Clear();
            tableRoom.Columns.Clear();
            tableRoom.DataSource = null;
            tableRoom.DataSource = dataTableRoom;
        }

        public void initTableRoomByTime()
        {
            DateTime from = fromTime.Value;
            DateTime to = toTime.Value;
            int days = Functions.getDayGap(from, to);
            if (days >= 0 && Functions.getDayGap(DateTime.Now, from) >= 0)
            {
                initTableRoom(from, to);
                //colRemoveTableRoom = 2;
            }
            else
            {
                initTableRoomEmpty();
            }
        }

        public void initTableBookedByReservationId(string reservationId)
        {
            dataTableBook.Rows.Clear();
            roomReservationBUS.getAllRoomReservationByReservationId(reservationId)
                .ForEach(item => dataTableBook.Rows.Add(item.RoomId, item.Room.RoomType.Name,
                item.StartTime.ToString(Configs.formatBirthday), item.EndTime.ToString(Configs.formatBirthday),
                RoomReservation.getStatusString(item.Status)));

            tableBook.DataSource = dataTableBook;
            addColumnAction(tableBook, "Remove", dataTableBook);
        }

        public void fillDataCustomer(Customer customer)
        {
            txtCCCD.Text = customer.CitizenID;
            txtPhone.Text = customer.PhoneNumber;
            txtName.Text = customer.FullName;
            string gender = customer.Gender == "1" ? "Male" : "Female";
            FormHelpers.setRadioButton(panelGender, gender);
            labelDontExist.Visible = false;
            btnAddCustomer.Enabled = false;
        }

        public string getCustomerId()
        {
            int index = 1;
            if (customerBUS.getLength() > 0)
            {
                index = customerBUS.getAll().Max(item => Functions.convertIdToInteger(item.Id, "CU")) + 1;
            }
            return "CU" + index.ToString("D3");
        }

        public void addReservation(Reservation reservation)
        {
            int result = reservationBUS.add(reservation);
            if (result > 0)
            {
                MessageBox.Show("Thêm danh sách đặt phòng thành công!");
                roomReservationBUS.addAllBookedRoomInReservation(getListRoomReservationFromBooked(reservation.Id));
                this.reservationUI.initTable();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Thêm danh sách đặt phòng không thành công!");
            }
        }

        public void updateReservation(Reservation reservation)
        {
            int result = reservationBUS.update(reservation);
            if (result > 0)
            {
                roomReservationBUS.deleteAllBookedRoomInReservation(reservation.Id);
                roomReservationBUS.addAllBookedRoomInReservation(getListRoomReservationFromBooked(reservation.Id));
                this.reservationUI.initTable();
                MessageBox.Show("Cập nhập danh sách đặt phòng thành công!");
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Cập nhập danh sách đặt phòng không thành công!");
            }
        }

        public int getRoomReservationIdInt()
        {
            int index = 1;
            if (roomReservationBUS.getAllRoomReservation().Count > 0)
            {
                index = roomReservationBUS.getAllRoomReservation().Max(item => Functions.convertIdToInteger(item.Id, "RR")) + 1;
            }
            return index;
        }

        public string getRoomReservationIdString(int index)
        {
            return "RR" + index.ToString("D5");
        }

        public List<RoomReservation> getListRoomReservationFromBooked(string reservationId)
        {
            List<RoomReservation> list = new List<RoomReservation>();

            int index = getRoomReservationIdInt();
            foreach (DataRow item in dataTableBook.Rows)
            {
                string room_id = item[0].ToString();
                DateTime fromTimeBook = Functions.convertStringToDateTime(item[2].ToString());
                DateTime toTimeBook = Functions.convertStringToDateTime(item[3].ToString());
                RoomReservationStatus status = RoomReservation.getStatusEnum(item[4].ToString());

                list.Add(new RoomReservation() { Id = getRoomReservationIdString(index++), RoomId = room_id, ReservationId = reservationId, StartTime = fromTimeBook, EndTime = toTimeBook, Status = status });
            }

            return list;

        }
        #endregion

        #region event
        private void btnSave_Click(object sender, EventArgs e)
        {
            string cccd = txtCCCD.Text;
            Customer customer = customerBUS.getCustomerByCCCD(cccd);

            if (customer != null)
            {
                string reservationId = txtId.Text;
                Reservation reservation = new Reservation()
                { Id = reservationId, CustomerID = customer.Id, StaffID = this.staffLogin.Id, CreatedAt = DateTime.Now };

                if (this.reservationOld != null)
                {
                    reservation.CreatedAt = this.reservationOld.CreatedAt;
                    updateReservation(reservation);
                }
                else
                {
                    addReservation(reservation);
                }
            }
            else
            {
                Customer customerAdd = new Customer();
                customerAdd.Id = getCustomerId();
                customerAdd.CitizenID = cccd;

                MessageBox.Show("Vui lòng thêm khách hàng trước khi đặt phòng");
                CustomerInfoUI customerInfoUI = new CustomerInfoUI(new CustomerUI(), this);
                customerInfoUI.fillData(customerAdd, "Thêm khách hàng");
                customerInfoUI.Show();
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Thoát đặt phòng", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void txtCCCD_TextChanged(object sender, EventArgs e)
        {
            string text = txtCCCD.Text;
            Customer customer = customerBUS.getCustomerByCCCD(text);
            bool checkExist = customer == null;
            labelDontExist.Visible = checkExist;
            btnAddCustomer.Enabled = checkExist;

            if (customer != null)
            {
                txtName.Text = customer.FullName;
                txtPhone.Text = customer.PhoneNumber;
                string gender = customer.Gender == "1" ? "Male" : "Female";
                FormHelpers.setRadioButton(panelGender, gender);
            }
            else
            {
                txtName.Text = "";
                txtPhone.Text = "";
            }
        }

        private void fromTime_ValueChanged(object sender, EventArgs e)
        {
            initTableRoomByTime();
        }

        private void toTime_ValueChanged(object sender, EventArgs e)
        {
            initTableRoomByTime();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            string cccd = txtCCCD.Text;
            string id = getCustomerId();
            CustomerInfoUI customerInfoUI = new CustomerInfoUI(new CustomerUI(), this);
            Customer customer = new Customer()
            { Id = id, CitizenID = cccd };
            customerInfoUI.fillData(customer, "Thêm khách hàng");
            customerInfoUI.Show();
        }

        private void tableRoom_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index < 0)
                return;

            string text = tableRoom.Rows[index].Cells[e.ColumnIndex].Value.ToString();
            if (!text.Equals("Add"))
                return;

            string roomId = tableRoom.Rows[index].Cells["ID"].Value.ToString();
            string type = tableRoom.Rows[index].Cells["Type"].Value.ToString();

            List<RoomReservation> bookedRooms = getListRoomReservationFromBooked(txtId.Text);

            dataTableRoom.Rows.RemoveAt(index);

            tableRoom.DataSource = dataTableRoom;

            string statusString = RoomReservation.getStatusString(RoomReservationStatus.Booked);
            string from = fromTime.Value.ToString(Configs.formatBirthday);
            string to = toTime.Value.ToString(Configs.formatBirthday);


            dataTableBook.Rows.Add(roomId, type, from, to, statusString);
            tableBook.DataSource = dataTableBook;

            addColumnAction(tableBook, "Remove", dataTableBook);
        }

        private void tableBook_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index < 0)
                return;
            string text = tableBook.Rows[index].Cells[e.ColumnIndex].Value.ToString();
            if (!text.Equals("Remove"))
                return;

            string roomId = tableBook.Rows[index].Cells["ID"].Value.ToString();
            string statusString = tableBook.Rows[index].Cells["Status"].Value.ToString();

            if (RoomReservation.getStatusEnum(statusString) != RoomReservationStatus.Booked)
            {
                MessageBox.Show($"Xóa phòng {roomId} không hợp lệ (Không phải ở trạng thái đã đặt)");
                return;
            }

            dataTableBook.Rows.RemoveAt(index);

            tableBook.DataSource = dataTableBook;
            initTableRoom(fromTime.Value, toTime.Value);
        }
        #endregion
    }
}
