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

namespace HotelManagement.GUI
{
    public partial class CustomerUI : Form
    {
        private CustomerBUS customerBUS = new CustomerBUS();
        DataTable dataTable = new DataTable();
        public CustomerUI()
        {
            InitializeComponent();
            dataTable.Columns.Add("Ma KH");
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
            list.ForEach(item => { dataTable.Rows.Add(item.Id, item.Fullname, item.Gender == 1 ? "Nam" : "Nữ", item.Birthday, item.CitizenId, item.Phone, item.Address); });

            dataGridView1.DataSource = dataTable;
        }
        #endregion

        #region event
        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            CustomerInfoUI customerInfoUI = new CustomerInfoUI(this);
            Customer customer = new Customer();
            string id = (customerBUS.getLength() + 1).ToString("D3");
            customer.Id = "CUS" + id;
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
                    int gender = selectedRow.Cells[2].Value.ToString() == "Nam" ? 1 :0;  
                    string birthday = selectedRow.Cells[3].Value.ToString();  
                    string cccd = selectedRow.Cells[4].Value.ToString();  
                    string phone = selectedRow.Cells[5].Value.ToString();  
                    string address = selectedRow.Cells[6].Value.ToString();

                    CustomerInfoUI customerInfoUI = new CustomerInfoUI(this);
                    Customer customer = new Customer(id,fullname,gender,birthday,address,cccd,phone);
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
                    if(MessageBox.Show("Bạn có chắc chắn muốn xóa hay không?","Xóa khách hàng", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        int result = customerBUS.delete(id);
                        if(result == 0)
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
        #endregion
    }
}
