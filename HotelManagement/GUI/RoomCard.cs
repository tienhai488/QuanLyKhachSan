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
            customerName.Text = UserName;
        }

        private void customerName_Click(object sender, EventArgs e)
        {
            RentRoomDetail rmDetail = new RentRoomDetail();
            rmDetail.ShowDialog();
        }

        private void RoomCard_Click(object sender, EventArgs e)
        {
            RentRoomDetail rmDetail = new RentRoomDetail();

            rmDetail.ShowDialog();

        }
    }
}
