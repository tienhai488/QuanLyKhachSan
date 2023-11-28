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

        ReservationUI reservationUI;

        private int colRemove = 0;
        public ReservBookingUI()
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

            initTableRoom(DateTime.Now, DateTime.Now);
            //initTableBook();

            labelDontExist.Visible = false;
        }

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

            initTableRoom(DateTime.Now, DateTime.Now);
            //initTableBook();

            labelDontExist.Visible = false;

            txtId.Text = reservationId;
            this.reservationUI = reservationUI;
        }

        #region method
        public void addColumnAction(DataGridView dtgv, string text)
        {
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.HeaderText = "Action";
            buttonColumn.Text = text;
            buttonColumn.UseColumnTextForButtonValue = true;

            dtgv.Columns.Add(buttonColumn);
        }

        public void removeItemInDataTableRoom(DateTime from, DateTime to)
        {
            foreach (DataRow item in dataTableBook.Rows)
            {
                string id = item[0].ToString();
                DateTime fromTimeBook = Functions.convertStringToDateTime(item[2].ToString());
                DateTime toTimeBook = Functions.convertStringToDateTime(item[3].ToString());
                if (Functions.getDayGap(fromTimeBook, from) == 0 && Functions.getDayGap(to, toTimeBook) == 0)
                {
                    DataRow rowToRemove = dataTableRoom.Rows.Cast<DataRow>().FirstOrDefault(row => row["ID"].Equals(id));
                    dataTableRoom.Rows.Remove(rowToRemove);
                }
            }
        }

        public void initTableRoom(DateTime from, DateTime to)
        {
            dataTableRoom.Rows.Clear();
            tableRoom.DataSource = null;
            tableRoom.Columns.Clear();
            roomReservationBUS.getListRoomAllowBooking(from).ForEach(item => dataTableRoom.Rows.Add(item.Id, item.RoomType.Name));

            removeItemInDataTableRoom(from, to);
            tableRoom.DataSource = dataTableRoom;
            if (tableRoom.Columns.Count <= 2)
            {
                addColumnAction(tableRoom, "Add");
            }
        }

        public void initTableRoomEmpty()
        {
            dataTableRoom.Rows.Clear();
            tableRoom.DataSource = null;
            tableRoom.Columns.Clear();
            tableRoom.DataSource = dataTableRoom;
        }

        public void initTableByTime()
        {
            DateTime from = fromTime.Value;
            DateTime to = toTime.Value;
            int days = Functions.getDayGap(from, to);
            if (days >= 0 && Functions.getDayGap(DateTime.Now, from) >= 0)
            {
                initTableRoom(from, to);
                colRemove = 2;
            }
            else
            {
                initTableRoomEmpty();
            }
        }

        public void fillDataCustomer(Customer customer)
        {
            txtCCCD.Text = customer.CitizenID;
            txtPhone.Text = customer.PhoneNumber;
            txtName.Text = customer.FullName;
            string gender = customer.Gender == "1" ? "Male" : "Female";
            setRadioButton(gender);
            labelDontExist.Visible = false;
            btnAddCustomer.Enabled = false;
        }

        public string getRadioButtonText()
        {

            foreach (RadioButton item in panelGender.Controls)
            {
                if (item.Checked)
                {
                    return item.Text;
                }
            }
            return "";
        }

        public void setRadioButton(string value)
        {
            foreach (RadioButton item in panelGender.Controls)
            {
                if (item.Text.Equals(value))
                {
                    item.Checked = true;
                    break;
                }
            }
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
                MessageBox.Show("Cập nhập danh sách đặt phòng thành công!");
                roomReservationBUS.deleteAllBookedRoomInReservation(reservation.Id);
                roomReservationBUS.addAllBookedRoomInReservation(getListRoomReservationFromBooked(reservation.Id));
                this.reservationUI.initTable();
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
                int status = 0;

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

                if (reservationBUS.checkReservationId(reservationId))
                {
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
                setRadioButton(gender);
            }
            else
            {
                txtName.Text = "";
                txtPhone.Text = "";
            }
        }

        private void fromTime_ValueChanged(object sender, EventArgs e)
        {
            initTableByTime();
        }

        private void toTime_ValueChanged(object sender, EventArgs e)
        {
            initTableByTime();
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
            if (e.ColumnIndex != colRemove)
                return;

            string roomId = tableRoom.Rows[index].Cells["ID"].Value.ToString();
            string type = tableRoom.Rows[index].Cells["Type"].Value.ToString();

            DataRow rowToRemove = dataTableRoom.Rows.Cast<DataRow>().FirstOrDefault(row => row["ID"].Equals(roomId));
            dataTableRoom.Rows.Remove(rowToRemove);

            tableRoom.DataSource = dataTableRoom;

            string from = fromTime.Value.ToString(Configs.formatBirthday);
            string to = toTime.Value.ToString(Configs.formatBirthday);

            dataTableBook.Rows.Add(roomId, type, from, to);
            tableBook.DataSource = dataTableBook;
            if (tableBook.Columns.Count <= 4)
            {
                addColumnAction(tableBook, "Remove");
            }
        }

        private void tableBook_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0 && e.ColumnIndex == 4)
            {
                string roomId = tableBook.Rows[index].Cells[0].Value.ToString();

                DataRow rowToRemove = dataTableBook.Rows.Cast<DataRow>().FirstOrDefault(row => row["ID"].Equals(roomId));
                dataTableBook.Rows.Remove(rowToRemove);

                tableBook.DataSource = dataTableBook;
                initTableRoom(fromTime.Value, toTime.Value);
                colRemove = 2;
            }
        }
        #endregion
    }
}
