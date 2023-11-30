using HotelManagement.BUS;
using HotelManagement.Business;
using HotelManagement.Data;
using HotelManagement.Data.Transfer;
using HotelManagement.Data.Transfer.Ultils;
using HotelManagement.Ultils;
using MaterialSkin;
using MaterialSkin.Controls;
using static iText.StyledXmlParser.Jsoup.Select.Evaluator;

namespace HotelManagement.GUI
{
    public partial class RentRoomDetailUI : MaterialForm
    {
        private RoomBUS roomBUS = new RoomBUS();
        private ReservationBUS reservationBUS = new ReservationBUS();
        private RoomReservationBUS roomReservationBUS = new RoomReservationBUS();
        private InvoiceBUS invoiceBUS = new InvoiceBUS();
        private RentRoomDetailBUS rentRoomDetailBUS = new RentRoomDetailBUS();
        private CustomerBUS customerBUS = new CustomerBUS();

        private Reservation reservationOld = null;
        private Room roomOld = null;
        private string roomStatusOld = null;
        private bool isCheckout = false;

        public RentRoomDetailUI(Reservation reservation, Room room, string roomStatus)
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
            Primary.Pink800,   // Main background color
            Primary.Purple900, // Darker background color
            Primary.Red100, // Accent background color
            Accent.Amber200,   // Warm accent color for highlights
            TextShade.WHITE);    // Text color

            this.reservationOld = reservation;
            this.roomOld = room;
            this.roomStatusOld = roomStatus;

            fillInfoCustomer(this.reservationOld.Customer);
            fillInfoRoom(this.roomOld, this.roomStatusOld);
            fillInfoRoomReservation(this.reservationOld.Id, this.roomOld.Id);

            txtInvoiceId.Text = getInvoiceId();
            initCbxRoomClean();

            this.isCheckout = txtRoomStatus.Text == "Rented";
            loadButtonForm();
        }

        #region method
        public void fillInfoCustomer(Customer customer)
        {
            txtCCCD.Text = customer.CitizenID;
            txtName.Text = customer.FullName;
            txtPhone.Text = customer.PhoneNumber;
        }

        public void fillInfoRoom(Room room, string roomStatus)
        {
            labelRoomID.Text = $"{room.Id} ({room.RoomType.Name})";
            cbxRoomClean.Text = roomBUS.convertRoomStatusToString(room.Status);
            txtRoomStatus.Text = roomStatus;
        }

        public void fillInfoRoomReservation(string reservationId, string roomId)
        {
            RoomReservation roomReservation = roomReservationBUS.getRoomReservation(reservationId, roomId);
            txtFrom.Text = roomReservation.StartTime.ToString(Configs.formatBirthday);
            txtTo.Text = roomReservation.EndTime.ToString(Configs.formatBirthday);

            datetimeChange.Value = roomReservation.EndTime;
        }

        public string getInvoiceId()
        {
            string result = "";
            Invoice invoice = this.reservationOld.Invoice;
            if (invoice == null)
            {
                int index = 1;
                if (invoiceBUS.getLength() > 0)
                {
                    index = invoiceBUS.getAll().Max(item => Functions.convertIdToInteger(item.Id, "IN")) + 1;
                }
                string id = "IN" + index.ToString("D4");
                result = id;
            }
            else
            {
                result = invoice.Id;
            }
            return result;
        }

        public void initCbxRoomClean()
        {
            cbxRoomClean.Items.Clear();
            cbxRoomClean.Items.Add("Cleaned");
            cbxRoomClean.Items.Add("NotCleanedYet");
            cbxRoomClean.Items.Add("Maintaining");

            cbxRoomClean.SelectedIndex = this.roomOld.Status;
        }

        public void loadButtonForm()
        {
            this.isCheckout = txtRoomStatus.Text == "Rented";
            btnUpdateService.Enabled = isCheckout;
            btnCheckout.Text = isCheckout ? "Checkout" : "Recive Room";
        }

        public string getRentRoomDetailId()
        {
            int index = 1;
            if (rentRoomDetailBUS.getLengthRentRoomDetail() > 0)
            {
                index = rentRoomDetailBUS.getAll().Max(item => Functions.convertIdToInteger(item.Id, "RR")) + 1;
            }
            return "RR" + index.ToString("D5");
        }

        public void handleCheckout()
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn trả phỏng không?", "Trả phòng", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;
            //int result = checkoutRentRoomDetail(this.reservationOld.Invoice.Id, this.roomOld.Id, )
        }



        public void handleReceiveRoom()
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn nhận phòng không?", "Nhận phòng", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;
            if (this.reservationOld.Invoice == null)
            {
                string cus_id = this.reservationOld.Customer.Id;
                int i = invoiceBUS.add(new Invoice() { Id = txtInvoiceId.Text, StaffID = 1, CustomerID = cus_id, ReservationID = this.reservationOld.Id });

                this.reservationOld = reservationBUS.getById(this.reservationOld.Id);
            }



            RentRoomDetail data = new RentRoomDetail();
            data.Id = getRentRoomDetailId();
            data.AddedTime = DateTime.Now;
            data.StartTime = Functions.convertStringToDateTime(txtFrom.Text);
            data.EndTime = Functions.convertStringToDateTime(txtTo.Text);
            data.RoomID = this.roomOld.Id;
            data.StaffID = 1;
            data.InvoiceID = txtInvoiceId.Text;

            rentRoomDetailBUS.add(data);

            int result = roomReservationBUS.updateStatusBookedToRented(this.reservationOld.Id, this.roomOld.Id, txtTo.Text, txtFrom.Text);

            if (result == 0)
            {
                MessageBox.Show("Nhận phòng không thành công");
            }
            else
            {
                MessageBox.Show("Nhận phòng thành công!");
            }
            loadButtonForm();
            initCbxRoomClean();

        }
        #endregion

        #region event
        private void btnChange_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdateService_Click(object sender, EventArgs e)
        {
            MessageBox.Show("nhan nut");
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            if (isCheckout)
            {
                handleCheckout();
            }
            else
            {
                handleReceiveRoom();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
