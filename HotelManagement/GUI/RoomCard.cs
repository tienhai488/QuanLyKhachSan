using HotelManagement.BUS;
using HotelManagement.Business;
using HotelManagement.Data;
using HotelManagement.Data.Transfer;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System.Runtime.CompilerServices;

namespace HotelManagement.GUI
{
    public partial class RoomCard : UserControl
    {
        private ReservationBUS reservationBUS = new ReservationBUS();
        private RoomReservationBUS roomReservationBUS = new RoomReservationBUS();
        private RoomBUS roomBUS = new RoomBUS();
        public RoomCard()
        {
            InitializeComponent();
        }

        public RoomCard(string id, string roomType, string txtMain, string roomStatus,
            string roomClean, string fromTime, string toTime, string reservationID)
        {
            InitializeComponent();
            labelRoomID.Text = id;
            labelRoomType.Text = roomType;
            labelMain.Text = txtMain;
            labelRoomStatus.Text = roomStatus;
            labelRoomClean.Text = roomClean;
            labelFromTime.Text = fromTime;
            labelToTime.Text = toTime;
            labelReservationID.Text = reservationID;
        }

        private void card_DoubleClick(object sender, EventArgs e)
        {
            string reservationID = labelReservationID.Text;
            if (reservationID != "")
            {
                Reservation reservation = reservationBUS.getById(reservationID);
                Room room = roomBUS.getRoomById(labelRoomID.Text);

                RentRoomDetailUI rentRoomDetail = new RentRoomDetailUI(reservation, room, labelRoomStatus.Text);
                rentRoomDetail.Show();
            }
            else
            {
                MessageBox.Show("Phòng chưa được đặt hay chưa đươc thuê!");
            }
        }

        
    }
}
