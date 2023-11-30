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
        public ReservBookingUI(ReservationUI reservationUI, string reservationId)
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
            Primary.Pink800,   // Main background color
            Primary.Purple900, // Darker background color
            Primary.Purple500, // Accent background color
            Accent.Amber200,   // Warm accent color for highlights
            TextShade.WHITE);    // Text color  

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
                string id = item[0].ToString();

                int index = -1;
                int temp = 0;
                foreach (DataRow row in dataTableRoom.Rows)
                {
                    if (row[0].Equals(id))
                    {
                        index = temp;
                        break;
                    }
                    temp++;
                }
                if (index != -1)
                {
                    dataTableRoom.Rows.RemoveAt(index);
                }

                //DateTime fromTimeBook = Functions.convertStringToDateTime(item[2].ToString());
                //DateTime toTimeBook = Functions.convertStringToDateTime(item[3].ToString());
                //if (Functions.getDayGap(fromTimeBook, from) == 0 && Functions.getDayGap(to, toTimeBook) == 0)
                //{
                //}
            }
        }


        public void initTableRoom(DateTime from, DateTime to)
        {
            dataTableRoom.Rows.Clear();
            tableRoom.DataSource = null;
            tableRoom.Columns.Clear();

            this.reservationOld = reservationBUS.getById(txtId.Text);
            if (this.reservationOld == null)
            {
                roomReservationBUS.getListRoomAllowBooking(from, to).ForEach(item => dataTableRoom.Rows.Add(item.Id, item.RoomType.Name));
            }
            else
            {
                roomReservationBUS.getListRoomAllowBookingWithReservationId(from, to, this.reservationOld.Id).ForEach(item => dataTableRoom.Rows.Add(item.Id, item.RoomType.Name));
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
                .ForEach(item => dataTableBook.Rows.Add(item.RoomID, item.Room.RoomType.Name,
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

        public List<RoomReservation> getListRoomReservationFromBooked(string reservationId)
        {
            List<RoomReservation> list = new List<RoomReservation>();

            foreach (DataRow item in dataTableBook.Rows)
            {
                string room_id = item[0].ToString();
                DateTime fromTimeBook = Functions.convertStringToDateTime(item[2].ToString());
                DateTime toTimeBook = Functions.convertStringToDateTime(item[3].ToString());
                RoomReservationStatus status = RoomReservation.getStatusEnum(item[4].ToString());

                list.Add(new RoomReservation() { RoomID = room_id, ReservationID = reservationId, StartTime = fromTimeBook, EndTime = toTimeBook, Status = status });
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
                { Id = reservationId, CustomerID = customer.Id, StaffID = 1, CreatedAt = DateTime.Now };

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
            bool checkContainRoomId = bookedRooms.Any(item => item.RoomID.Equals(roomId));
            if (checkContainRoomId)
            {
                MessageBox.Show($"Phiếu đặt phòng đã có phòng {roomId}! Vui lòng kiểm tra lại!");
                return;
            }

            DataRow rowToRemove = dataTableRoom.Rows.Cast<DataRow>().FirstOrDefault(row => row["ID"].Equals(roomId));
            dataTableRoom.Rows.Remove(rowToRemove);

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

            DataRow rowToRemove = dataTableBook.Rows.Cast<DataRow>().FirstOrDefault(row => row["ID"].Equals(roomId));
            dataTableBook.Rows.Remove(rowToRemove);

            tableBook.DataSource = dataTableBook;
            initTableRoom(fromTime.Value, toTime.Value);
        }
        #endregion
    }
}
