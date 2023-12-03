using HotelManagement.BUS;
using HotelManagement.Data;
using HotelManagement.Ultils;
using System.Globalization;

namespace HotelManagement.GUI
{
    public partial class CustomerInfoUI : Form
    {
        private bool isEdit = false;
        private CustomerBUS customerBUS = new CustomerBUS();
        private CustomerUI customerUI;
        private ReservBookingUI reservBookingUI = null;
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

        public CustomerInfoUI(CustomerUI customerUI, ReservBookingUI reservBookingUI)
        {
            InitializeComponent();
            initCbxGender();
            this.customerUI = customerUI;
            this.reservBookingUI = reservBookingUI;
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
            txtId.Text = customer.Id;
            txtFullname.Text = customer.FullName;
            txtCCCD.Text = customer.CitizenID;
            txtAddress.Text = customer.Address;
            txtPhone.Text = customer.PhoneNumber;
            dateTimeBirthday.Value = customer.Birthday;
            cbxGender.Text = customer.GenderString;

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
                    if (this.reservBookingUI != null)
                    {

                        this.reservBookingUI.fillDataCustomer(customer);
                    }
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
                    if (this.reservBookingUI != null)
                    {

                        this.reservBookingUI.fillDataCustomer(customer);
                    }
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
            string gender = cbxGender.Text == "Name" ? "1" : "0";
            DateTime birthday = dateTimeBirthday.Value;
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
