using HotelManagement.BUS;
using HotelManagement.Business;
using HotelManagement.Data;
using HotelManagement.Data.Transfer;
using HotelManagement.Data.Transfer.Ultils;
using HotelManagement.Ultils;
using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using Microsoft.Extensions.Logging.Abstractions;
using System.Data;
using System.Text;

namespace HotelManagement.GUI
{
    public partial class RentRoomDetailUI : MaterialForm
    {
        private RoomBUS roomBUS = new RoomBUS();
        private CustomerBUS customerBUS = new CustomerBUS();
        private ReservationBUS reservationBUS = new ReservationBUS();
        private RoomReservationBUS roomReservationBUS = new RoomReservationBUS();
        private InvoiceBUS invoiceBUS = new InvoiceBUS();
        private RentRoomDetailBUS rentRoomDetailBUS = new RentRoomDetailBUS();
        private UseServiceDetailBUS useServiceDetailBUS = new UseServiceDetailBUS();

        private Reservation reservationOld = null;
        private Room roomOld = null;
        private string roomStatusOld = null;
        private bool isCheckout = false;
        private RoomReservation roomReservationOld = null;
        private RentRoomDetail rentRoomDetailOld = null;
        private RentRoomsUI rentRoomsUIOld = null;

        private DataTable useServiceTable = new DataTable();

        public RentRoomDetailUI(RentRoomsUI rentRoomsUI, Reservation reservation, RoomReservation roomReservation, Room room, string roomStatus)
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
            this.roomReservationOld = roomReservation;
            this.rentRoomsUIOld = rentRoomsUI;

            useServiceTable.Columns.Add("Name");
            useServiceTable.Columns.Add("Price");
            useServiceTable.Columns.Add("Quantity");
            useServiceTable.Columns.Add("Total");

            fillInfoCustomer(this.reservationOld.Customer);
            fillInfoRoom(this.roomOld, this.roomStatusOld);
            fillInfoRoomReservation();

            txtInvoiceId.Text = getInvoiceId();
            initCbxRoomClean();

            this.isCheckout = txtRoomStatus.Text == "Rented";
            loadButtonForm();

            this.rentRoomDetailOld = rentRoomDetailBUS.getRentRoomDetail(this.roomOld.Id, txtFrom.Text, txtTo.Text);
            initUseServiceTable();
        }

        #region method
        public void initUseServiceTable()
        {
            if (this.rentRoomDetailOld == null)
            {
                labelRentRoomId.Text = "";
            }
            labelRentRoomId.Text = $"Rent Room ID : {this.rentRoomDetailOld.Id}";
            useServiceTable.Rows.Clear();
            dataGridViewService.DataSource = null;

            useServiceDetailBUS.getServiceByRentRoomID(this.rentRoomDetailOld.Id)
                .ForEach(item => useServiceTable.Rows.Add(item.Service.Name, item.Service.UnitPrice.ToString("N0"), item.Quantity, (item.Quantity * item.Service.UnitPrice).ToString("N0")));
            dataGridViewService.DataSource = useServiceTable;
        }
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

        public void fillInfoRoomReservation()
        {
            if (this.roomReservationOld == null)
                return;
            txtFrom.Text = this.roomReservationOld.StartTime.ToString(Configs.formatBirthday);
            txtTo.Text = this.roomReservationOld.EndTime.ToString(Configs.formatBirthday);

            datetimeChange.Value = this.roomReservationOld.EndTime;

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



        public void handleCheckout()
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn trả phỏng không?", "Trả phòng", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;
            DateTime to = Functions.convertStringToDateTime(txtTo.Text);
            if (this.rentRoomDetailOld == null)
            {
                this.rentRoomDetailOld = rentRoomDetailBUS.getRentRoomDetail(this.roomOld.Id, txtFrom.Text, txtTo.Text);
            }
            if(Functions.getDayGap(to, DateTime.Now) >= 0)
            {
                roomBUS.updateRoomStatusToNotCleanYet(rentRoomDetailOld.RoomID);

                roomReservationBUS.updateStatusBookedToPaid(roomReservationOld.Id);

                //rentRoomDetailBUS.updatePaidTime(this.rentRoomDetailOld.Id);
                rentRoomDetailBUS.updatePaidTime(rentRoomDetailOld.Id);

                MessageBox.Show("Thực hiện trả phòng thành công!");

                InvoicePdfUI invoicePdfUI = new InvoicePdfUI(this.rentRoomDetailOld);
                invoicePdfUI.Show();
                this.rentRoomsUIOld.initFlowLayoutRoom();
                this.Close();
            }
            else
            {
                MessageBox.Show("Chưa tới thời hạn trả phòng vui lòng kiểm tra lại hoặc thay đổi ngày trả phòng!");
            }
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
            data.Id = rentRoomDetailBUS.getRentRoomDetailId();
            data.AddedTime = DateTime.Now;
            data.StartTime = Functions.convertStringToDateTime(txtFrom.Text);
            data.EndTime = Functions.convertStringToDateTime(txtTo.Text);
            data.RoomID = this.roomOld.Id;
            data.StaffID = 1;
            data.InvoiceID = txtInvoiceId.Text;

            rentRoomDetailBUS.add(data);

            int result = 0;
            if (this.roomReservationOld != null)
            {
                result = roomReservationBUS.updateStatusBookedToRented(this.roomReservationOld.Id);
            }
            else
            {
                MessageBox.Show("Không tim thấy phòng đã đặt!");
            }

            if (result == 0)
            {
                MessageBox.Show("Nhận phòng không thành công");
                this.rentRoomsUIOld.initFlowLayoutRoom();
            }
            else
            {
                MessageBox.Show("Nhận phòng thành công!");
                txtRoomStatus.Text = "Rented";
                loadButtonForm();
                initUseServiceTable();
            }


        }
        #endregion

        #region event
        private void btnChange_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            string roomType = cbxRoomClean.Text;
            DateTime endTimeUpdate = datetimeChange.Value;
            bool checkInitRentRoomsUI = false;

            int statusUpdate = roomBUS.convertStringToRoomStatus(roomType);
            if (this.roomOld.Status != statusUpdate)
            {
                if (statusUpdate != -1)
                {
                    int roomResult = roomBUS.updateRoomStatus(this.roomOld.Id, statusUpdate);
                    if (roomResult != 0)
                    {
                        sb.AppendLine("Cập nhập trạng thái dọn dẹp phòng thành công");
                        this.roomOld.Status = statusUpdate;
                        checkInitRentRoomsUI = true;
                    }
                    else
                    {
                        sb.AppendLine("Cập nhập trạng thái dọn dẹp phòng không thành công");
                    }
                }
                else
                {
                    sb.AppendLine("Vui lòng kiểm tra lại trạng thái dọn dẹp phòng");
                }
            }


            string from = txtFrom.Text;
            string to = txtTo.Text;
            if (!endTimeUpdate.ToString(Configs.formatBirthday).Equals(to))
            {
                if (Functions.getDayGap(DateTime.Now, endTimeUpdate) >= 0)
                {
                    List<RoomReservation> listRoom = roomReservationBUS.getListRoomReservationBookedAndRentedHistory(endTimeUpdate);
                    bool doubleCheck = listRoom
                        .Where(item => !item.StartTime.ToString(Configs.formatBirthday).Equals(from) && !item.EndTime.ToString(Configs.formatBirthday).Equals(to))
                        .ToList()
                        .Any(item => item.Equals(this.roomOld.Id));
                    if (!doubleCheck)
                    {
                        if (this.rentRoomDetailOld != null)
                        {
                            rentRoomDetailBUS.updateEndTime(this.rentRoomDetailOld.Id, endTimeUpdate);
                            this.rentRoomDetailOld.EndTime = endTimeUpdate;
                        }

                        roomReservationBUS.updateEndTime(this.roomReservationOld.Id, endTimeUpdate);
                        this.roomReservationOld.EndTime = endTimeUpdate;
                        sb.AppendLine("Cập nhập ngày trả phòng thành công");
                        txtTo.Text = endTimeUpdate.ToString(Configs.formatBirthday);
                        checkInitRentRoomsUI = true;
                    }
                    else
                    {
                        sb.AppendLine("Ngày bạn chọn đã trùng lịch!");
                    }
                }
                else
                {
                    sb.AppendLine("Ngày trả phòng bạn chọn nhỏ hơn ngày hiện tại!");
                }
            }

            if (sb.Length > 0)
            {
                MessageBox.Show(sb.ToString());
            }

            if (checkInitRentRoomsUI)
            {
                this.rentRoomsUIOld.initFlowLayoutRoom();
            }
        }

        private void btnUpdateService_Click(object sender, EventArgs e)
        {
            if (this.rentRoomDetailOld == null)
            {
                this.rentRoomDetailOld = rentRoomDetailBUS.getRentRoomDetail(this.roomOld.Id, txtFrom.Text, txtTo.Text);
            }

            UpdateService updateService = new UpdateService(this, this.rentRoomDetailOld);
            updateService.Show();
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Thoát nhận phòng", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }
        #endregion
    }
}
