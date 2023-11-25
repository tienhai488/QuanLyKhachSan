using MaterialSkin;
using MaterialSkin.Controls;
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
    public partial class ReservBookingUI : MaterialForm
    {
        public ReservBookingUI()
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
        }

        private void materialButton3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            CustomerInfoUI csInfo = new CustomerInfoUI();
            csInfo.ShowDialog();
        }
    }
}
