using HotelManagement.BUS;
using HotelManagement.Business;
using HotelManagement.Data;
using HotelManagement.Data.Transfer;
using HotelManagement.Ultils;
using MaterialSkin;
using MaterialSkin.Controls;

namespace HotelManagement.GUI
{
    public partial class RentRoomsUI : MaterialForm
    {
        private CustomerBUS customerBUS = new CustomerBUS();
        private RoomBUS roomBUS = new RoomBUS();
        private ReservationBUS reservationBUS = new ReservationBUS();
        private RoomReservationBUS roomReservationBUS = new RoomReservationBUS();

        private RoomReservationStatus roomStatusFilter = RoomReservationStatus.All;
        private string roomTypeFilter = "All";
        private int roomCleanFilter = -1;

        private System.Threading.Timer timer;
        public RentRoomsUI()
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

            roomReservationBUS.loadOutDateAllRoomReservation();
            initRadioButtonRoomType();
            initFlowLayoutRoom();
        }

        #region method
        public void initFlowLayoutRoom()
        {
            clearRoomView();

            List<RoomReservation> listRoom = roomReservationBUS.getListRoomReservationBookedAndRentedHistory(datetimeFilter.Value);

            roomBUS.getAllRoom()
                .Where(item =>
                {
                    bool checkRoomStatus = true;
                    bool checkRoomType = true;
                    bool checkRoomClean = true;

                    if (this.roomStatusFilter != RoomReservationStatus.All)
                    {
                        RoomReservation roomReservation = listRoom.Find(roomRe => roomRe.RoomID.Equals(item.Id));
                        if (roomReservation != null)
                        {
                            checkRoomStatus = roomReservation.Status == this.roomStatusFilter;
                        }
                        else
                        {
                            checkRoomStatus = this.roomStatusFilter == RoomReservationStatus.Empty;
                        }
                    }

                    if (!this.roomTypeFilter.Equals("All") && this.roomTypeFilter != "")
                    {
                        checkRoomType = item.RoomType.Name.Equals(this.roomTypeFilter);
                    }

                    if (this.roomCleanFilter != -1)
                    {
                        checkRoomClean = item.Status == this.roomCleanFilter;
                    }

                    return checkRoomStatus && checkRoomType && checkRoomClean && item.Id.ToLower().Contains(txtFilter.Text.ToLower());
                })
                .ToList()
                .ForEach(item =>
                {
                    string labelMain = "Empty Room";
                    string roomStatus = "Empty";
                    string roomClean = roomBUS.convertRoomStatusToString(item.Status);
                    string from = "From: ";
                    string to = "To: ";
                    string labelReservationID = "";
                    RoomReservation roomReservation = listRoom.Find(roomRe => roomRe.RoomID.Equals(item.Id));
                    if (roomReservation != null)
                    {
                        labelMain = roomReservation.Reservation.Customer.FullName;
                        roomStatus = RoomReservation.getStatusString(roomReservation.Status);
                        from += roomReservation.StartTime.ToString(Configs.formatBirthday);
                        to += roomReservation.EndTime.ToString(Configs.formatBirthday);
                        labelReservationID = roomReservation.ReservationID;
                    }
                    addRoomView(item.Id, item.RoomType.Name, labelMain, roomStatus, roomClean, from, to, labelReservationID);
                });
        }

        public void initRadioButtonRoomType()
        {
            panelRoomType.Controls.Clear();

            roomBUS.getAllRoomType().OrderByDescending(item => item.Name).ToList().ForEach(roomType =>
            {
                addRadioButton(panelRoomType, roomType.Name);
            });

            addRadioButton(panelRoomType, "All");

        }

        public void addRadioButton(Panel panel, string text)
        {
            MaterialRadioButton radio = new MaterialRadioButton();
            radio.AutoSize = true;
            radio.Depth = 0;
            radio.Dock = DockStyle.Top;
            radio.Location = new Point(0, 111);
            radio.Margin = new Padding(0);
            radio.MouseLocation = new Point(-1, -1);
            radio.MouseState = MaterialSkin.MouseState.HOVER;
            radio.Name = "materialRadioButton8";
            radio.Ripple = true;
            radio.Size = new Size(188, 37);
            radio.TabIndex = 13;
            radio.TabStop = true;
            radio.UseVisualStyleBackColor = true;
            radio.Text = text;
            radio.MouseUp += roomType_MouseUp;

            if (text == "All")
            {
                radio.Checked = true;
            }
            panel.Controls.Add(radio);
        }

        public void addRoomView(string id, string roomType, string labelMain, string roomStatus, string roomClean, string fromTime, string toTime, string reservationID)
        {
            RoomCard room = new RoomCard(id, roomType, labelMain, roomStatus, roomClean, fromTime, toTime, reservationID);
            flowLayoutRooms.Controls.Add(room);
        }

        public void clearRoomView()
        {
            flowLayoutRooms.Controls.Clear();
        }

        private void TimerCallback(object state)
        {
            if (txtFilter.InvokeRequired)
            {
                txtFilter.Invoke(new MethodInvoker(delegate
                {
                    // Thực hiện hành động cần thiết sau khi chờ đợi 500ms
                    initFlowLayoutRoom();
                }));
            }
            else
            {
                // Nếu đang chạy trên luồng chính, thực hiện ngay lập tức
                initFlowLayoutRoom();
            }
        }
        #endregion


        #region event

        private void datetimeFilter_ValueChanged(object sender, EventArgs e)
        {
            initFlowLayoutRoom();
        }

        private void txtFilter_KeyUp(object sender, KeyEventArgs e)
        {
            timer?.Change(Timeout.Infinite, Timeout.Infinite);

            // Tạo một timer mới và đặt thời gian chờ đợi là 500ms
            timer = new System.Threading.Timer(TimerCallback, null, 500, Timeout.Infinite);
        }

        private void roomStatus_MouseUp(object sender, MouseEventArgs e)
        {
            string value = FormHelpers.getRadioButtonText(panelRoomStatus);
            RoomReservationStatus status = RoomReservation.getStatusEnum(value);
            this.roomStatusFilter = status;
            initFlowLayoutRoom();
        }

        private void roomType_MouseUp(object sender, MouseEventArgs e)
        {
            this.roomTypeFilter = FormHelpers.getRadioButtonText(panelRoomType);
            initFlowLayoutRoom();
        }

        private void roomClean_MouseUp(object sender, MouseEventArgs e)
        {
            string value = FormHelpers.getRadioButtonText(panelRoomClean);
            this.roomCleanFilter = roomBUS.convertStringToRoomStatus(value);

            initFlowLayoutRoom();
        }

        #endregion


    }

}
