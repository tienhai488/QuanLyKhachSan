using HotelManagement.BUS;
using HotelManagement.Business;
using HotelManagement.Data;
using HotelManagement.Data.Access;
using HotelManagement.Data.Transfer.Ultils;
using HotelManagement.Ultils;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Data;
using System.Windows.Forms;

namespace HotelManagement.GUI
{
    public partial class InvoiceListUI : MaterialForm
    {
        private BindingSource bindingSourceInvoice = new BindingSource();
        private DataTable invoiceTable = new DataTable();

        private RentRoomDetailBUS rentRoomDetailBUS = new RentRoomDetailBUS();

        private System.Threading.Timer timer;
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

            DateTime date = dateTimePickerInvoice.Value;

            rentRoomDetailBUS.getAll().Where(item => Functions.getDayGap(date, item.PaidTime) == 0).ToList()
            .ForEach(item =>
            {
                string paidTime = Functions.getDayGap(item.PaidTime, Functions.convertStringToDateTime("01/01/0001")) == 0 ? "" : item.PaidTime.ToString(Configs.formatBirthday);
                invoiceTable.Rows.Add(item.InvoiceID, item.Id, item.RoomID, item.Staff.FullName, item.StartTime.ToString(Configs.formatBirthday), item.EndTime.ToString(Configs.formatBirthday), item.AddedTime, paidTime);
            });

            dataGridViewInvoice.DataSource = invoiceTable;
            bindingSourceInvoice.DataSource = invoiceTable;
        }

        private void TimerCallback(object state)
        {
            if (txtRentRoomId.InvokeRequired)
            {
                txtRentRoomId.Invoke(new MethodInvoker(delegate
                {
                    // Thực hiện hành động cần thiết sau khi chờ đợi 500ms
                    bindingSourceInvoice.Filter = @$"
                    `RentRoomID` like '%{txtRentRoomId.Text}%'
                    
                    ";

                    dataGridViewInvoice.DataSource = bindingSourceInvoice;
                }));
            }
            else
            {
                // Nếu đang chạy trên luồng chính, thực hiện ngay lập tức
                bindingSourceInvoice.Filter = @$"
                    `RentRoomID` like '%{txtRentRoomId.Text}%'
                    ";

                dataGridViewInvoice.DataSource = bindingSourceInvoice;
            }
        }
        #endregion

        private void dateTimePickerInvoice_ValueChanged(object sender, EventArgs e)
        {
            initInvoiceTable();
        }

        private void txtRentRoomId_TextChanged(object sender, EventArgs e)
        {
            timer?.Change(Timeout.Infinite, Timeout.Infinite);

            // Tạo một timer mới và đặt thời gian chờ đợi là 500ms
            timer = new System.Threading.Timer(TimerCallback, null, 500, Timeout.Infinite);
        }
        #region event


        private void dataGridViewInvoice_DoubleClick(object sender, EventArgs e)
        {
            if(dataGridViewInvoice.SelectedRows.Count == 0)
            {
                MessageBox.Show("No row select");
                return;
            }
            DataGridViewCell selectedCell = dataGridViewInvoice.SelectedCells[0];

            DataGridViewRow selectedRow = selectedCell.OwningRow;

            string rentRoomId = selectedRow.Cells["RentRoomID"].Value.ToString();

            InvoicePdfUI invoicePdfUI = new InvoicePdfUI(rentRoomDetailBUS.getRentRoomById(rentRoomId));
            invoicePdfUI.Show();
        }
        #endregion



    }
}

