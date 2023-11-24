namespace HotelManagement.GUI
{
    public partial class RoomCard : UserControl
    {
        public RoomCard()
        {
            InitializeComponent();
        }

        public RoomCard(String UserName)
        {
            InitializeComponent();
            materialLabel5.Text = UserName;
        }

        private void materialLabel5_Click(object sender, EventArgs e)
        {
            RentRoomDetail rmDetail = new RentRoomDetail();
            rmDetail.ShowDialog();
        }
    }
}
