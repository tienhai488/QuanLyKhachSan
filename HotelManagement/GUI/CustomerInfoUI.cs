using HotelManagement.BUS;
using HotelManagement.DTO;
using HotelManagement.Ultils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement.GUI
{
    public partial class CustomerInfoUI : Form
    {
        private bool isEdit = false;
        private CustomerBUS customerBUS = new CustomerBUS();
        private CustomerUI customerUI;
        public CustomerInfoUI()
        {
            InitializeComponent();
            initCbxGender();
        }

        public CustomerInfoUI(CustomerUI customerUI)
        {
            InitializeComponent();
            initCbxGender();
            this.customerUI = customerUI;
        }

        #region method
        public void initCbxGender()
        {
            cbxGender.Items.Clear();
            cbxGender.Items.Add("Nữ");
            cbxGender.Items.Add("Nam");
        }
        public void fillData(Customer customer, string type)
        {
            if (customer.Birthday != "")
            {
                dateTimeBirthday.Value = DateTime.ParseExact(customer.Birthday, Configs.formatBirthday, CultureInfo.InvariantCulture, DateTimeStyles.None);
            }
            txtId.Text = customer.Id;
            txtFullname.Text = customer.Fullname;
            txtCCCD.Text = customer.CitizenId;
            txtAddress.Text = customer.Address;
            txtPhone.Text = customer.Phone;

            cbxGender.SelectedIndex = customer.Gender;

            btnSave.Text = type;
            isEdit = type == "Lưu thông tin" ? true : false;
        }

        public void addCustomer(Customer customer)
        {

            if (customerBUS.validate(customer))
            {
                int result = customerBUS.add(customer);
                if (result > 0)
                {
                    MessageBox.Show("Thêm khách hàng thành công!");
                    this.customerUI.initTable();
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Thêm khách hàng không thành công!");
                }
            }
        }

        public void updateCustomer(Customer customer)
        {
            if (customerBUS.validate(customer))
            {
                int result = customerBUS.update(customer);
                if (result > 0)
                {
                    MessageBox.Show("Cập nhật khách hàng thành công!");
                    this.customerUI.initTable();
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Cập nhật khách hàng không thành công!");
                }
            }
        }

        #endregion


        #region event
        private void btnSave_Click(object sender, EventArgs e)
        {
            string id = txtId.Text;
            string fullname = txtFullname.Text;
            int gender = cbxGender.SelectedIndex;
            string birthday = dateTimeBirthday.Value.ToString(Configs.formatBirthday);
            string address = txtAddress.Text;
            string phone = txtPhone.Text;
            string cccd = txtCCCD.Text;

            Customer customer = new Customer(id, fullname, gender, birthday, address, cccd, phone);
            if (isEdit)
            {
                updateCustomer(customer);
            }
            else
            {
                addCustomer(customer);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtFullname.Text = "";
            txtCCCD.Text = "";
            txtAddress.Text = "";
            txtPhone.Text = "";

            cbxGender.SelectedIndex = 0;
            dateTimeBirthday.Value = DateTime.Now;
        }
        #endregion


    }
}
