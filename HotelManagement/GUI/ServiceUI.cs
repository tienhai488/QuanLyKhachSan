using HotelManagement.BUS;
using HotelManagement.DTO;
using HotelManagement.Ultils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement.GUI
{
    public partial class ServiceUI : Form
    {
        private BindingSource bindingSourceService = new BindingSource();
        private BindingSource bindingSourceServiceType = new BindingSource();
        private ServiceBUS serviceBUS = new ServiceBUS();
        private DataTable typeTable = new DataTable();
        private DataTable serviceTable = new DataTable();
        public ServiceUI()
        {
            InitializeComponent();
            typeTable.Columns.Add("Mã Loại");
            typeTable.Columns.Add("Tên Loại");

            serviceTable.Columns.Add("Mã DV");
            serviceTable.Columns.Add("Tên DV");
            serviceTable.Columns.Add("Loại DV");
            serviceTable.Columns.Add("Giá DV");
            serviceTable.Columns.Add("Đơn Vị");

            initTypeTable();
            initServiceTable();
        }

        #region method
        public void initServiceTable()
        {
            serviceTable.Rows.Clear();
            dtgvService.DataSource = null;

            List<Service> list = new List<Service>();
            list = serviceBUS.getAllService();
            list.ForEach(item => { serviceTable.Rows.Add(item.Id, item.Name, item.Service_type_name, item.Unit_price, item.Unit); });

            dtgvService.DataSource = serviceTable;
            bindingSourceService.DataSource = serviceTable;

            initCbxFilterAllService();
        }
        public void initTypeTable()
        {
            typeTable.Rows.Clear();
            dtgvType.DataSource = null;
            List<ServiceType> list = new List<ServiceType>();
            list = serviceBUS.getAllType();
            list.ForEach(item => { typeTable.Rows.Add(item.Id, item.Name); });

            dtgvType.DataSource = typeTable;
            bindingSourceServiceType.DataSource = typeTable;

            initCbxFilterAllServiceType();
        }

        public void initCbxFilterAllService()
        {
            FormHelpers.initCbxFilter(cbxFilterServiceID, 0, dtgvService);
            FormHelpers.initCbxFilter(cbxFilterServiceName, 1, dtgvService);
            FormHelpers.initCbxFilter(cbxFilterServiceType, 2, dtgvService);
        }

        public void initCbxFilterAllServiceType()
        {
            FormHelpers.initCbxFilter(cbxFilterTypeID, 0, dtgvType);
            FormHelpers.initCbxFilter(cbxFilterTypeName, 1, dtgvType);
        }
        #endregion

        #region event
        private void btnAddService_Click(object sender, EventArgs e)
        {
            int index = serviceBUS.getLengthService() + 1;
            string id = "SV" + index.ToString("D3");
            ServiceInfoUI serviceInfoUI = new ServiceInfoUI(this);
            Service service = new Service();
            service.Id = id;
            serviceInfoUI.fillData(service, "Thêm dịch vụ");
            serviceInfoUI.Show();
        }

        private void btnUpdateService_Click(object sender, EventArgs e)
        {
            int selectedCellCount =
dtgvService.SelectedCells.Count;
            if (selectedCellCount > 0)
            {
                DataGridViewCell selectedCell = dtgvService.SelectedCells[0];

                DataGridViewRow selectedRow = selectedCell.OwningRow;

                if (!selectedRow.IsNewRow)
                {
                    string id = selectedRow.Cells[0].Value.ToString();
                    string name = selectedRow.Cells[1].Value.ToString();
                    double unitPrice = Double.Parse(selectedRow.Cells[3].Value.ToString());
                    string unit = selectedRow.Cells[4].Value.ToString();
                    string serviceTypeName = selectedRow.Cells[2].Value.ToString();

                    ServiceInfoUI serviceInfoUI = new ServiceInfoUI(this);
                    Service service = new Service(id, name, unitPrice, unit, "", serviceTypeName);

                    serviceInfoUI.fillData(service, "Lưu thông tin");
                    serviceInfoUI.Show();
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn dịch vụ muốn cập nhập!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dịch vụ muốn cập nhập!");
            }
        }

        private void btnDeleteService_Click(object sender, EventArgs e)
        {
            int selectedCellCount =
        dtgvService.SelectedCells.Count;
            if (selectedCellCount > 0)
            {
                DataGridViewCell selectedCell = dtgvService.SelectedCells[0];

                // Lấy dòng chứa ô đó
                DataGridViewRow selectedRow = selectedCell.OwningRow;
                // Lấy dòng được chọn (lấy dòng đầu tiên nếu có nhiều dòng được chọn)

                if (!selectedRow.IsNewRow)
                {
                    string id = selectedRow.Cells[0].Value.ToString();
                    if (MessageBox.Show("Bạn có chắc chắn muốn xóa hay không?", "Xóa dịch vụ", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        int result = serviceBUS.deleteService(id);
                        if (result == 0)
                        {
                            MessageBox.Show("Xóa dịch vụ không thành công!");
                        }
                        else
                        {
                            MessageBox.Show("Xóa dịch vụ thành công!");
                            initServiceTable();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn dịch vụ muốn xóa!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dịch vụ muốn xóa!");
            }
        }

        private void btnAddType_Click(object sender, EventArgs e)
        {
            ServiceTypeInfoUI ui = new ServiceTypeInfoUI(this);
            int index = serviceBUS.getLengthType() + 1;
            string id = "ST" + index.ToString("D3");
            ui.fillData(new ServiceType(id, ""), "Thêm loại");
            ui.Show();
        }

        private void btnUpdateType_Click(object sender, EventArgs e)
        {
            int selectedCellCount =
dtgvType.SelectedCells.Count;
            if (selectedCellCount > 0)
            {
                DataGridViewCell selectedCell = dtgvType.SelectedCells[0];

                // Lấy dòng chứa ô đó
                DataGridViewRow selectedRow = selectedCell.OwningRow;
                // Lấy dòng được chọn (lấy dòng đầu tiên nếu có nhiều dòng được chọn)

                if (!selectedRow.IsNewRow)
                {
                    string id = selectedRow.Cells[0].Value.ToString();
                    string name = selectedRow.Cells[1].Value.ToString();

                    ServiceTypeInfoUI serviceTypeInfoUI = new ServiceTypeInfoUI(this);
                    ServiceType serviceType = new ServiceType(id, name);
                    serviceTypeInfoUI.fillData(serviceType, "Lưu thông tin");
                    serviceTypeInfoUI.Show();
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn loại dịch vụ muốn cập nhập!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn loại dịch vụ muốn cập nhập!");
            }
        }

        private void btnDeleteType_Click(object sender, EventArgs e)
        {
            int selectedCellCount =
        dtgvType.SelectedCells.Count;
            if (selectedCellCount > 0)
            {
                DataGridViewCell selectedCell = dtgvType.SelectedCells[0];

                // Lấy dòng chứa ô đó
                DataGridViewRow selectedRow = selectedCell.OwningRow;
                // Lấy dòng được chọn (lấy dòng đầu tiên nếu có nhiều dòng được chọn)

                if (!selectedRow.IsNewRow)
                {
                    string id = selectedRow.Cells[0].Value.ToString();
                    if (MessageBox.Show("Bạn có chắc chắn muốn xóa hay không?", "Xóa loại dịch vụ", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        if (serviceBUS.getLengServiceForType(id) == 0)
                        {
                            int result = serviceBUS.deleteType(id);
                            if (result == 0)
                            {
                                MessageBox.Show("Xóa loại dịch vụ không thành công!");
                            }
                            else
                            {
                                MessageBox.Show("Xóa loại dịch vụ thành công!");
                                initTypeTable();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Đã tồn tại dịch vụ thuộc loại dịch vụ này vui lòng kiểm tra lại!");
                        }

                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn loại dịch vụ muốn xóa!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn loại dịch vụ muốn xóa!");
            }
        }
        #endregion


        private void btnDelFilterServiceID_Click(object sender, EventArgs e)
        {
            cbxFilterServiceID.Text = String.Empty;
        }

        private void btnDelFilterServiceName_Click(object sender, EventArgs e)
        {
            cbxFilterServiceName.Text = String.Empty;
        }

        private void btnDelFilterServiceType_Click(object sender, EventArgs e)
        {
            cbxFilterServiceType.Text = String.Empty;
        }

        private void btnDeleteAllFilterService_Click(object sender, EventArgs e)
        {
            cbxFilterServiceID.Text = String.Empty;
            cbxFilterServiceName.Text = String.Empty;
            cbxFilterServiceType.Text = String.Empty;
        }

        private void btnFilterService_Click(object sender, EventArgs e)
        {
            string id = cbxFilterServiceID.Text;
            string name = cbxFilterServiceName.Text;
            string type = cbxFilterServiceType.Text;

            bindingSourceService.Filter = @$"
            `Mã DV` like '%{id}%' and
            `Tên DV` like '%{name}%' and
            `Loại DV` like '%{type}%'
            ";

            dtgvService.DataSource = bindingSourceService;
            initCbxFilterAllService();

        }

        private void btnDelFilterTypeID_Click(object sender, EventArgs e)
        {
            cbxFilterTypeID.Text = String.Empty;
        }

        private void btnDelFilterTypeName_Click(object sender, EventArgs e)
        {
            cbxFilterTypeName.Text = String.Empty;
        }

        private void btnDeleteAllFilterType_Click(object sender, EventArgs e)
        {
            cbxFilterTypeID.Text = String.Empty;
            cbxFilterTypeName.Text = String.Empty;
        }

        private void btnFilterType_Click(object sender, EventArgs e)
        {
            string id = cbxFilterTypeID.Text;
            string name = cbxFilterTypeName.Text;


            bindingSourceServiceType.Filter = @$"
            `Mã Loại` like '%{id}%' and
            `Tên Loại` like '%{name}%'
            ";

            dtgvType.DataSource = bindingSourceServiceType;
            initCbxFilterAllServiceType();
        }
    }
}
