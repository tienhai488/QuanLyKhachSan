using HotelManagement.BUS;
using HotelManagement.DTO;
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
using HotelManagement.BUS;
using HotelManagement.DTO;
using System.Xml.Linq;
using MaterialSkin;

namespace HotelManagement.GUI
{
    public partial class RentRoomsUI : MaterialForm
    {
        private CustomerBUS customerBUS = new CustomerBUS();
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
        }

        public void addRoomView(String name)
        {
            RoomCard room = new RoomCard(name);
            flowLayoutPanel1.Controls.Add(room);
        }

        public void clearRoomView()
        {
            flowLayoutPanel1.Controls.Clear();
        }

        private void materialRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            clearRoomView();
            List<Customer> list = new List<Customer>();
            list = customerBUS.getAll();
            foreach (Customer customer in list)
            {
                addRoomView(customer.Fullname);
            }
        }

    }

}
