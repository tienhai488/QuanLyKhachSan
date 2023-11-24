using HotelManagement.BUS;
using MaterialSkin.Controls;
using MaterialSkin;
using HotelManagement.Data;

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
            room.Size = new Size(295, 150);
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
                addRoomView(customer.FullName);
            }
        }

    }

}
