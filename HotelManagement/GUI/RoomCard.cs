using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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

        private void RoomCard_Load(object sender, EventArgs e)
        {

        }
    }
}
