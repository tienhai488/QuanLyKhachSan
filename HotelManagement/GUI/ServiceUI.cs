using HotelManagement.BUS;
using HotelManagement.Data;
using HotelManagement.Ultils;
using System.Data;
using HotelManagement.Data.Transfer.Ultils;

namespace HotelManagement.GUI
{
    public partial class ServiceUI : MaterialForm
    {
        private BindingSource bindingSourceService = new BindingSource();
        private BindingSource bindingSourceServiceType = new BindingSource();
        private ServiceBUS serviceBUS = new ServiceBUS();
        private DataTable typeTable = new DataTable();
        private DataTable serviceTable = new DataTable();
        public ServiceUI()
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

            serviceBUS.getAllService()
            .ForEach(item =>
            {
                serviceTable.Rows.Add(item.Id, item.Name, item.ServiceType.Name, item.UnitPrice, item.Unit);
            });

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
            FormHelpers.initCbxFilter(cbxFilterTypeName2, 1, dtgvType);
        }
        #endregion

        #region event

        private void mbtnDelFilterServiceID_Click(object sender, EventArgs e)
        {
            cbxFilterServiceID.Text = String.Empty;
        }

        private void mbtnDelFilterServiceName_Click(object sender, EventArgs e)
        {
            cbxFilterServiceName.Text = String.Empty;
        }

        private void mbtnDelFilterServiceType_Click(object sender, EventArgs e)
        {
            cbxFilterServiceType.Text = String.Empty;
        }

        private void mbtnDeleteAllFilterService_Click(object sender, EventArgs e)
        {
            cbxFilterServiceID.Text = String.Empty;
            cbxFilterServiceName.Text = String.Empty;
            cbxFilterServiceType.Text = String.Empty;
        }

        private void mbtnFilterService_Click(object sender, EventArgs e)
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

        private void mbtnAddService_Click(object sender, EventArgs e)
        {
            int index = 1;
            if (serviceBUS.getLengthService() > 0)
            {
                index = serviceBUS.getAllService().Max(item => Functions.convertIdToInteger(item.Id, "SE")) + 1;
            }
            string id = "SE" + index.ToString("D3");
            ServiceInfoUI serviceInfoUI = new ServiceInfoUI(this);
            serviceInfoUI.fillData(id, "", 0, "", "", "Thêm dịch vụ");
            serviceInfoUI.Show();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            int selectedCellCount = dtgvService.SelectedCells.Count;
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

                    serviceInfoUI.fillData(id, name, unitPrice, unit, serviceTypeName, "Lưu thông tin");
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

        private void materialButton1_Click_1(object sender, EventArgs e)
        {
            int selectedCellCount = dtgvService.SelectedCells.Count;
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

        private void mbtnDeleteService_Click(object sender, EventArgs e)
        {
            int selectedCellCount = dtgvService.SelectedCells.Count;
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

        private void materialButton1_Click_2(object sender, EventArgs e)
        {

        }

        private void mbtnDelFilterTypeID_Click(object sender, EventArgs e)
        {
            cbxFilterTypeID.Text = String.Empty;
        }

        private void mbtnDelFilterTypeName_Click(object sender, EventArgs e)
        {
            cbxFilterTypeName2.Text = String.Empty;
        }

        private void mbtnDeleteAllFilterType_Click(object sender, EventArgs e)
        {
            cbxFilterTypeID.Text = String.Empty;
            cbxFilterTypeName2.Text = String.Empty;
        }

        private void mbtnFilterType_Click(object sender, EventArgs e)
        {
            string id = cbxFilterTypeID.Text;
            string name = cbxFilterTypeName2.Text;


            bindingSourceServiceType.Filter = @$"
            `Mã Loại` like '%{id}%' and
            `Tên Loại` like '%{name}%'
            ";

            dtgvType.DataSource = bindingSourceServiceType;
            initCbxFilterAllServiceType();
        }

        private void mbtnAddType_Click(object sender, EventArgs e)
        {
            int index = 1;
            if (serviceBUS.getLengthType() > 0)
            {
                index = serviceBUS.getAllType().Max(item => Functions.convertIdToInteger(item.Id, "ST")) + 1;
            }
            string id = "ST" + index.ToString("D2");
            ServiceTypeInfoUI ui = new ServiceTypeInfoUI(this);
            ui.fillData(id, "", "Thêm loại");
            ui.Show();
        }

        private void mbtnUpdateType_Click(object sender, EventArgs e)
        {
            int selectedCellCount = dtgvType.SelectedCells.Count;
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
                    serviceTypeInfoUI.fillData(id, name, "Lưu thông tin");
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

        private void mbtnDeleteType_Click(object sender, EventArgs e)
        {
            int selectedCellCount = dtgvType.SelectedCells.Count;
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
                        int n = serviceBUS.getLengServiceForType(id);
                        if (n == 0)
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
        }


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
            string type = cbxFilterServiceType.Text.Trim();

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
        #endregion
    }
}
