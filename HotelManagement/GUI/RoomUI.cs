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

namespace HotelManagement.GUI
{
    public partial class RoomUI : MaterialForm
    {
        private CustomerBUS customerBUS = new CustomerBUS();
        public RoomUI()
        {
            InitializeComponent();
        }

        public void addRoomView(String name)
        {
            RoomView room = new RoomView(name);
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
