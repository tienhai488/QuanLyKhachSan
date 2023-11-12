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
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            addForm();
        }
        private void addForm()
        {
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