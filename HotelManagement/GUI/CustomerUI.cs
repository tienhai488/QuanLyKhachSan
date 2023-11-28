using System.Data;
using System.Globalization;
using HotelManagement.BUS;
using HotelManagement.Data;
using HotelManagement.Data.Transfer.Ultils;
using HotelManagement.Ultils;

namespace HotelManagement.GUI
{
    public partial class CustomerUI : Form
    {
        private BindingSource bindingSource = new BindingSource();
        private CustomerBUS customerBUS = new CustomerBUS();
        DataTable dataTable = new DataTable();
        public CustomerUI()
        {
            InitializeComponent();
            dataTable.Columns.Add("Mã KH");
            dataTable.Columns.Add("Họ Tên");
            dataTable.Columns.Add("Giới Tính");
            dataTable.Columns.Add("Ngày Sinh");
            dataTable.Columns.Add("CCCD");
            dataTable.Columns.Add("SDT");
            dataTable.Columns.Add("Địa Chỉ");

            initTable();
        }

        #region method
        public void initTable()
        {
            dataTable.Rows.Clear();
            dataGridView1.DataSource = null;
            List<Customer> list = new List<Customer>();
            list = customerBUS.getAll();
            list.ForEach(item => { dataTable.Rows.Add(item.Id, item.FullName, item.GenderString, item.Birthday.ToString(Configs.formatBirthday), item.CitizenID, item.PhoneNumber, item.Address); });

            dataGridView1.DataSource = dataTable;
            bindingSource.DataSource = dataTable;
            initCbxFilterAll();
        }

        public void initCbxFilterAll()
        {
            FormHelpers.initCbxFilter(cbxFilterID, 0, dataGridView1);
            FormHelpers.initCbxFilter(cbxFilterName, 1, dataGridView1);
            FormHelpers.initCbxFilter(cbxFilterGender, 2, dataGridView1);
            FormHelpers.initCbxFilter(cbxFilterCCCD, 4, dataGridView1);
        }


        #endregion

        #region event
        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            int index = 1;
            if (customerBUS.getLength() > 0)
            {
                index = customerBUS.getAll().Max(item => Functions.convertIdToInteger(item.Id, "CU")) + 1;
            }
            string id = "CU" + index.ToString("D3");
            CustomerInfoUI customerInfoUI = new CustomerInfoUI(this);
            Customer customer = new Customer() { Id = id, Gender = "1" };
            customerInfoUI.fillData(customer, "Thêm khách hàng");
            customerInfoUI.Show();
        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            int selectedCellCount =
        dataGridView1.SelectedCells.Count;
            if (selectedCellCount > 0)
            {
                DataGridViewCell selectedCell = dataGridView1.SelectedCells[0];

                // Lấy dòng chứa ô đó
                DataGridViewRow selectedRow = selectedCell.OwningRow;
                // Lấy dòng được chọn (lấy dòng đầu tiên nếu có nhiều dòng được chọn)

                if (!selectedRow.IsNewRow)
                {
                    string id = selectedRow.Cells[0].Value.ToString();
                    string fullname = selectedRow.Cells[1].Value.ToString();
                    string gender = selectedRow.Cells[2].Value.ToString() == "Nam" ? "1" : "0";
                    string birthday = selectedRow.Cells[3].Value.ToString();
                    string cccd = selectedRow.Cells[4].Value.ToString();
                    string phone = selectedRow.Cells[5].Value.ToString();
                    string address = selectedRow.Cells[6].Value.ToString();

                    DateTime birth = DateTime.ParseExact(birthday, Configs.formatBirthday, CultureInfo.InvariantCulture, DateTimeStyles.None);
                    CustomerInfoUI customerInfoUI = new CustomerInfoUI(this);
                    Customer customer = new Customer(id, fullname, gender, birth, address, cccd, phone);
                    customerInfoUI.fillData(customer, "Lưu thông tin");
                    customerInfoUI.Show();
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn khách hàng muốn cập nhập!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn khách hàng muốn cập nhập!");
            }
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            int selectedCellCount =
        dataGridView1.SelectedCells.Count;
            if (selectedCellCount > 0)
            {
                DataGridViewCell selectedCell = dataGridView1.SelectedCells[0];

                // Lấy dòng chứa ô đó
                DataGridViewRow selectedRow = selectedCell.OwningRow;
                // Lấy dòng được chọn (lấy dòng đầu tiên nếu có nhiều dòng được chọn)

                if (!selectedRow.IsNewRow)
                {
                    string id = selectedRow.Cells[0].Value.ToString();
                    if (MessageBox.Show("Bạn có chắc chắn muốn xóa hay không?", "Xóa khách hàng", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        int result = customerBUS.delete(id);
                        if (result == 0)
                        {
                            MessageBox.Show("Xóa khách hàng không thành công!");
                        }
                        else
                        {
                            MessageBox.Show("Xóa khách hàng thành công!");
                            initTable();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn khách hàng muốn xóa!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn khách hàng muốn xóa!");
            }
        }

        private void btnDelFilterID_Click(object sender, EventArgs e)
        {
            cbxFilterID.Text = string.Empty;
        }

        private void cbxDeleteFilterName_Click(object sender, EventArgs e)
        {
            cbxFilterName.Text = string.Empty;
        }

        private void cbxDeleteFilterGender_Click(object sender, EventArgs e)
        {
            cbxFilterGender.Text = string.Empty;
        }

        private void cbxDeleteFilterCCCD_Click(object sender, EventArgs e)
        {
            cbxFilterCCCD.Text = string.Empty;
        }

        private void btnDeleteAllFilter_Click(object sender, EventArgs e)
        {
            cbxFilterID.Text = string.Empty;
            cbxFilterName.Text = string.Empty;
            cbxFilterGender.Text = string.Empty;
            cbxFilterCCCD.Text = string.Empty;
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            string id = cbxFilterID.Text;
            string name = cbxFilterName.Text;
            string gender = cbxFilterGender.Text;
            string cccd = cbxFilterCCCD.Text;

            bindingSource.Filter = @$"
            `Mã KH` like '%{id}%' and
            `Họ Tên` like '%{name}%' and
            `Giới Tính` like '%{gender}%' and
            `CCCD` like '%{cccd}%'
            ";

            dataGridView1.DataSource = bindingSource;
            initCbxFilterAll();

        }

        #endregion
    }
}
