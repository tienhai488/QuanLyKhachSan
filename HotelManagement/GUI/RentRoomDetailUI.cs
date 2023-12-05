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

        private Staff staffLogin = LoginBO.SignedInStaff;

        public RentRoomDetailUI(RentRoomsUI rentRoomsUI, Reservation reservation, RoomReservation roomReservation, Room room, string roomStatus)
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
            useServiceTable.Rows.Clear();
            dataGridViewService.DataSource = null;

            if (this.rentRoomDetailOld == null)
            {
                labelRentRoomId.Text = "";
            }
            else
            {
                labelRentRoomId.Text = $"Rent Room ID : {this.rentRoomDetailOld.Id}";
                useServiceDetailBUS.getServiceByRentRoomID(this.rentRoomDetailOld.Id)
                .ForEach(item => useServiceTable.Rows.Add(item.Service.Name, item.Service.UnitPrice.ToString("N0"), item.Quantity, (item.Quantity * item.Service.UnitPrice).ToString("N0")));
            }

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

            datetimeStartChange.Value = this.roomReservationOld.StartTime;
            datetimeEndChange.Value = this.roomReservationOld.EndTime;

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
            datetimeStartChange.Enabled = !isCheckout;
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
            if (Functions.getDayGap(to, DateTime.Now) >= 0)
            {
                roomBUS.updateRoomStatusToNotCleanYet(rentRoomDetailOld.RoomID);

                roomReservationBUS.updateStatusBookedToPaid(roomReservationOld.Id);

                //rentRoomDetailBUS.updatePaidTime(this.rentRoomDetailOld.Id);
                rentRoomDetailBUS.updatePaidTime(rentRoomDetailOld.Id);

                MessageBox.Show("Thực hiện trả phòng thành công!");

                InvoicePdfUI invoicePdfUI = new InvoicePdfUI(rentRoomDetailBUS.getRentRoomById(this.rentRoomDetailOld.Id));
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

            DateTime startTime = Functions.convertStringToDateTime(txtFrom.Text);
            if (Functions.getDayGap(startTime, DateTime.Now) < 0)
            {
                MessageBox.Show("Chưa tới thời hạn nhận phòng vui lòng kiểm tra lại hoặc thay đổi ngày nhận phòng!");
                return;
            }

            if (this.reservationOld.Invoice == null)
            {
                string cus_id = this.reservationOld.Customer.Id;
                int i = invoiceBUS.add(new Invoice() { Id = txtInvoiceId.Text, StaffID = this.staffLogin.Id, CustomerID = cus_id, ReservationID = this.reservationOld.Id });

                this.reservationOld = reservationBUS.getById(this.reservationOld.Id);
            }

            RentRoomDetail data = new RentRoomDetail();
            data.Id = rentRoomDetailBUS.getRentRoomDetailId();
            data.AddedTime = DateTime.Now;
            data.StartTime = Functions.convertStringToDateTime(txtFrom.Text);
            data.EndTime = Functions.convertStringToDateTime(txtTo.Text);
            data.RoomID = this.roomOld.Id;
            data.StaffID = this.staffLogin.Id;
            data.InvoiceID = txtInvoiceId.Text;

            rentRoomDetailBUS.add(data);
            this.rentRoomDetailOld = rentRoomDetailBUS.getRentRoomById(data.Id);

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
                this.rentRoomsUIOld.initFlowLayoutRoom();
            }
        }
        #endregion

        #region event
        private void btnChange_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            string roomType = cbxRoomClean.Text;
            DateTime startTimeUpdate = datetimeStartChange.Value;
            DateTime endTimeUpdate = datetimeEndChange.Value;
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

            if (Functions.getDayGap(startTimeUpdate, endTimeUpdate) >= 0)
            {
                List<RoomReservation> listRoomStart = roomReservationBUS.getListRoomReservationBookedAndRentedHistory(startTimeUpdate);
                List<RoomReservation> listRoomEnd = roomReservationBUS.getListRoomReservationBookedAndRentedHistory(endTimeUpdate);

                bool doubleCheckStart = listRoomStart
                    .Where(item => !item.Id.Equals(this.roomReservationOld.Id))
                    .ToList()
                    .Any(item => item.RoomId.Equals(this.roomOld.Id));
                bool doubleCheckEnd = listRoomEnd
                    .Where(item => !item.Id.Equals(this.roomReservationOld.Id))
                    .ToList()
                    .Any(item => item.RoomId.Equals(this.roomOld.Id));

                if (this.rentRoomDetailOld == null)
                {
                    if (!startTimeUpdate.ToString(Configs.formatBirthday).Equals(from))
                    {
                        if (Functions.getDayGap(DateTime.Now, startTimeUpdate) >= 0)
                        {
                            if (!doubleCheckStart && !doubleCheckEnd)
                            {
                                roomReservationBUS.updateStartTime(this.roomReservationOld.Id, startTimeUpdate);
                                this.roomReservationOld.StartTime = startTimeUpdate;
                                sb.AppendLine("Cập nhập ngày nhận phòng thành công");
                                txtFrom.Text = startTimeUpdate.ToString(Configs.formatBirthday);
                                checkInitRentRoomsUI = true;
                            }
                            else
                            {
                                sb.AppendLine("Ngày bạn chọn đã trùng lịch!");
                            }
                        }
                        else
                        {
                            sb.AppendLine("Ngày nhận phòng bạn chọn nhỏ hơn ngày hiện tại!");
                        }
                    }
                }

                if (!endTimeUpdate.ToString(Configs.formatBirthday).Equals(to))
                {
                    if (Functions.getDayGap(DateTime.Now, endTimeUpdate) >= 0)
                    {
                        if (!doubleCheckStart && !doubleCheckEnd)
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
            }
            else
            {
                sb.AppendLine("Ngày bắt đầu và kết thúc khi thay đổi không hợp lệ!");
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
