using MaterialSkin;
using MaterialSkin.Controls;
using Org.BouncyCastle.Crmf;
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
    public partial class MainUI : MaterialForm
    {
        public MainUI()
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
            addForm();
        }
        private void addForm()
        {
            ReservationUI reservationForm = new ReservationUI();
            reservationForm.TopLevel = false;
            reservationForm.FormBorderStyle = FormBorderStyle.None;
            reservationForm.Dock = DockStyle.Fill;
            reservationForm.Show();
            tabPage2.Controls.Add(reservationForm);

            RoomUI roomForm = new RoomUI();
            roomForm.TopLevel = false;
            roomForm.FormBorderStyle = FormBorderStyle.None;
            roomForm.Dock = DockStyle.Fill;
            roomForm.Show();
            tabPage3.Controls.Add(roomForm);

            ServiceUI serviceForm = new ServiceUI();
            serviceForm.TopLevel = false;
            serviceForm.FormBorderStyle = FormBorderStyle.None;
            serviceForm.Dock = DockStyle.Fill;
            serviceForm.Show();
            tabPage7.Controls.Add(serviceForm);

            CustomerUI customerForm = new CustomerUI();
            customerForm.TopLevel = false;
            customerForm.FormBorderStyle = FormBorderStyle.None;
            customerForm.Dock = DockStyle.Fill;
            customerForm.Show();
            tabPage8.Controls.Add(customerForm);
        }
    }
}