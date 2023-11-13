using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement.GUI
{
    public partial class RentListUI : UserControl
    {
        public RentListUI()
        {
            InitializeComponent();
        }

        public RentListUI(String UserName)
        {
            InitializeComponent();
            customerName.Text = UserName;
        }
    }
}
