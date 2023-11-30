using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;

namespace HotelManagement.GUI
{
    public partial class RoomCard : UserControl
    {
        public RoomCard()
        {
            InitializeComponent();
        }

        public RoomCard(string id, string typeName, string txtMain, string reserTypeName, string statusClean, string fromTime, string toTime)
        {
            InitializeComponent();
            labelRoomID.Text = id;
            labelRoomType.Text = typeName;
            labelMain.Text = txtMain;
            labelReservationStatus.Text = reserTypeName;
            labelRoomStatusClean.Text = statusClean;
            labelFromTime.Text = fromTime;
            labelToTime.Text = toTime;
        }

        private void card_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("thanh nien");
        }
    }
}
