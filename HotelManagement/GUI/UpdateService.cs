using HotelManagement.BUS;
using HotelManagement.Business;
using HotelManagement.Data;
using HotelManagement.Data.Transfer.Ultils;
using HotelManagement.Ultils;
using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.VisualBasic;
using OfficeOpenXml;
using System.Data;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace HotelManagement.GUI
{
    public partial class UpdateService : MaterialForm
    {
        private BindingSource bindingSourceService = new BindingSource();
        private BindingSource bindingSourceServiceType = new BindingSource();
        private ServiceBUS serviceBUS = new ServiceBUS();
        private RentRoomDetailBUS rentRoomDetailBUS = new RentRoomDetailBUS();
        private UseServiceDetailBUS useServiceDetailBUS = new UseServiceDetailBUS();

        private DataTable serviceTable = new DataTable();
        private DataTable selectedTable = new DataTable();

        private RentRoomDetail rentRoomDetailOld = null;
        private RentRoomDetailUI rentRoomDetailUIOld = null;

        private Staff staffLogin = LoginBO.SignedInStaff;
        public UpdateService()
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

            selectedTable.Columns.Add("ID");
            selectedTable.Columns.Add("Name");
            selectedTable.Columns.Add("Price");
            selectedTable.Columns.Add("Quantity");
            selectedTable.Columns.Add("Total");

            serviceTable.Columns.Add("ID");
            serviceTable.Columns.Add("Name");
            serviceTable.Columns.Add("Type");
            serviceTable.Columns.Add("Price");
            serviceTable.Columns.Add("Unit");

            initServiceTable();
            initSelectedTable();
        }

        public UpdateService(RentRoomDetailUI rentRoomDetailUI ,RentRoomDetail rentRoomDetail)
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

            selectedTable.Columns.Add("ID");
            selectedTable.Columns.Add("Name");
            selectedTable.Columns.Add("Price");
            selectedTable.Columns.Add("Quantity");
            selectedTable.Columns.Add("Total");

            serviceTable.Columns.Add("ID");
            serviceTable.Columns.Add("Name");
            serviceTable.Columns.Add("Type");
            serviceTable.Columns.Add("Price");
            serviceTable.Columns.Add("Unit");

            this.rentRoomDetailOld = rentRoomDetail;
            this.rentRoomDetailUIOld = rentRoomDetailUI;

            initServiceTable();
            initSelectedTable();
        }

        #region method
        public void initServiceTable()
        {
            serviceTable.Rows.Clear();
            dataGridViewService.DataSource = null;

            serviceBUS.getAllService()
            .ForEach(item =>
            {
                serviceTable.Rows.Add(item.Id, item.Name, item.ServiceType.Name, item.UnitPrice.ToString("N0"), item.Unit);
            });

            dataGridViewService.DataSource = serviceTable;
            bindingSourceService.DataSource = serviceTable;

            initCbxFilterAllService();
        }

        public void initSelectedTable()
        {
            selectedTable.Rows.Clear();
            dataGridViewSelected.DataSource = null;

            if (this.rentRoomDetailOld == null)
                return;

            useServiceDetailBUS.getServiceByRentRoomID(this.rentRoomDetailOld.Id)
                .ForEach(item => selectedTable.Rows.Add(item.ServiceID, item.Service.Name, item.Service.UnitPrice.ToString("N0"), item.Quantity, (item.Quantity * item.Service.UnitPrice).ToString("N0")));

            dataGridViewSelected.DataSource = selectedTable;
        }

        public void initCbxFilterAllService()
        {
            FormHelpers.initCbxFilter(cbxFilterType, 2, dataGridViewService);
        }
        #endregion


        #region event
        private void mbtnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewSelected.SelectedRows.Count > 0)
            {
                dataGridViewSelected.Rows.RemoveAt(dataGridViewSelected.SelectedRows[0].Index);
            }
            else
            {
                MessageBox.Show("No row selected.");
            }
        }

        private void mbtnSelectService_Click(object sender, EventArgs e)
        {
            if (dataGridViewService.SelectedRows.Count == 0)
            {
                MessageBox.Show("No row selected."); ;
                return;
            }
            DataGridViewRow selectedRow = dataGridViewService.SelectedRows[0];
            foreach (DataGridViewRow row in dataGridViewSelected.Rows)
            {
                if (selectedRow.Cells["ID"].Value.ToString().Equals(row.Cells["ID"].Value.ToString()))
                {
                    int i = Int32.Parse(row.Cells["Quantity"].Value.ToString()) + 1;
                    row.Cells["Quantity"].Value = i.ToString();
                    row.Cells["Total"].Value = (i * Int32.Parse(selectedRow.Cells["Price"].Value.ToString(), NumberStyles.AllowThousands)).ToString("N0");
                    return;
                }
            }
            string id = selectedRow.Cells["ID"].Value.ToString();
            string name = selectedRow.Cells["Name"].Value.ToString();
            string price = selectedRow.Cells["Price"].Value.ToString();

            selectedTable.Rows.Add(id, name, price, "1", price);
            dataGridViewSelected.DataSource = selectedTable;
        }

        private void mcmbServiceType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string type = cbxFilterType.Text.Trim();

            bindingSourceService.Filter = @$"
            `Type` like '%{type}%'
            ";

            dataGridViewService.DataSource = bindingSourceService;
        }

        private void mbtnCheckOut_Click(object sender, EventArgs e)
        {
            if (rentRoomDetailOld == null)
            {
                MessageBox.Show("Không tìm thấy phiếu thuê phòng hợp lệ vui lòng kiểm tra lại!");
                return;
            }
            List<UseServiceDetail> list = new List<UseServiceDetail>();
            int index = useServiceDetailBUS.getUseServiceDetailIDInt();
            if (dataGridViewSelected.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridViewSelected.Rows)
                {
                    UseServiceDetail detail = new UseServiceDetail();
                    detail.Id = useServiceDetailBUS.getUseServiceDetailIDString(index++);
                    detail.Quantity = Int32.Parse(row.Cells["Quantity"].Value.ToString());
                    detail.ServiceID = row.Cells["ID"].Value.ToString();
                    detail.RentRoomID = this.rentRoomDetailOld.Id;
                    detail.StaffID = this.staffLogin.Id;
                    list.Add(detail);
                }
            }
            useServiceDetailBUS.deleteAllUseServiceByRentRoomId(this.rentRoomDetailOld.Id);
            useServiceDetailBUS.addListUseService(list);

            this.rentRoomDetailUIOld.initUseServiceTable();

            MessageBox.Show("Thêm dịch vụ cho phiếu thuê phòng thành công!");
            this.Close();
        }

        private void mbtnChangeQuantity_Click(object sender, EventArgs e)
        {
            if (dataGridViewSelected.SelectedRows.Count == 0)
            {
                MessageBox.Show("No row selected.");
                return;
            }

            DataGridViewRow selectedRow = dataGridViewSelected.SelectedRows[0];

            string id = selectedRow.Cells["ID"].Value.ToString();
            string name = selectedRow.Cells["Name"].Value.ToString();
            string price = selectedRow.Cells["Price"].Value.ToString();
            string quantity = selectedRow.Cells["Quantity"].Value.ToString();

            string q = Interaction.InputBox("Enter quantity: ", $"Change Quantity {id} - {name}", quantity).ToString();

            if (q == "")
                return;

            int quantityUpdate;
            if (int.TryParse(q, out quantityUpdate))
            {
                if (quantityUpdate < 0)
                {
                    MessageBox.Show("Invalid data."); return;
                }
                else if (quantityUpdate == 0)
                    dataGridViewSelected.Rows.RemoveAt(selectedRow.Index);
                else
                {
                    selectedRow.Cells["Quantity"].Value = quantityUpdate + "";
                    selectedRow.Cells["Total"].Value = (quantityUpdate * Int32.Parse(price, NumberStyles.AllowThousands)).ToString("N0");
                }
            }
            else
            {
                MessageBox.Show("Invalid data.");
            }
        }
        #endregion
    }
}