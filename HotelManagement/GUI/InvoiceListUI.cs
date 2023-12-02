using HotelManagement.BUS;
using HotelManagement.Business;
using HotelManagement.Data;
using HotelManagement.Data.Access;
using HotelManagement.Data.Transfer.Ultils;
using HotelManagement.Ultils;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Data;

namespace HotelManagement.GUI
{
    public partial class InvoiceListUI : MaterialForm
    {
        private BindingSource bindingSourceInvoice = new BindingSource();
        private DataTable invoiceTable = new DataTable();

        private RentRoomDetailBUS rentRoomDetailBUS = new RentRoomDetailBUS();
        public InvoiceListUI()
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

            invoiceTable.Columns.Add("InvoiceID");
            invoiceTable.Columns.Add("RentRoomID");
            invoiceTable.Columns.Add("Room");
            invoiceTable.Columns.Add("Staff");
            invoiceTable.Columns.Add("StartTime");
            invoiceTable.Columns.Add("EndTime");
            invoiceTable.Columns.Add("AddedTime");
            invoiceTable.Columns.Add("PaidTime");

            initInvoiceTable();
        }

        #region method
        public void initInvoiceTable()
        {
            invoiceTable.Rows.Clear();
            dataGridViewInvoice.DataSource = null;

            rentRoomDetailBUS.getAll()
            .ForEach(item =>
            {
                string paidTime = Functions.getDayGap(item.PaidTime, Functions.convertStringToDateTime("01/01/0001")) == 0 ? "" : item.PaidTime.ToString(Configs.formatBirthday);
                invoiceTable.Rows.Add(item.InvoiceID, item.Id, item.RoomID, item.Staff.FullName, item.StartTime.ToString(Configs.formatBirthday), item.EndTime.ToString(Configs.formatBirthday), item.AddedTime, paidTime);
            });

            dataGridViewInvoice.DataSource = invoiceTable;
            bindingSourceInvoice.DataSource = invoiceTable;
        }
        #endregion

        #region event
        private void dateTimePickerInvoice_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtRentRoomId_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewInvoice_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewCell selectedCell = dataGridViewInvoice.SelectedCells[0];

            DataGridViewRow selectedRow = selectedCell.OwningRow;

            string rentRoomId = selectedRow.Cells["RentRoomID"].Value.ToString();

            InvoicePdfUI invoicePdfUI = new InvoicePdfUI(rentRoomDetailBUS.getRentRoomById(rentRoomId));
            invoicePdfUI.Show();
        }
        #endregion



    }
}

