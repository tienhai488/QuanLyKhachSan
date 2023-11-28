using HotelManagement.Business;
using HotelManagement.Data;
using HotelManagement.Data.Transfer.Ultils;
using HotelManagement.Ultils;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Data;

namespace HotelManagement.GUI
{
    public partial class ReservationUI : MaterialForm
    {
        private BindingSource bindingSource = new BindingSource();
        private ReservationBUS reservationBUS = new ReservationBUS();
        DataTable dataTable = new DataTable();
        public ReservationUI()
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

            dataTable.Columns.Add("ID");
            dataTable.Columns.Add("Customer");
            dataTable.Columns.Add("Staff");
            dataTable.Columns.Add("CreatdAt");

            initTable();
        }

        #region method
        public void initTable()
        {
            dataTable.Rows.Clear();
            dataGridView1.DataSource = null;

            reservationBUS.getAll().ForEach(item =>
            {
                dataTable.Rows.Add(item.Id, item.Customer.FullName, item.Staff.FullName, item.CreatedAt.ToString(Configs.formatDateTime));
            });
            dataGridView1.DataSource = dataTable;
            bindingSource.DataSource = dataTable;
            initCbxFilterAll();
        }

        public void initCbxFilterAll()
        {
            FormHelpers.initCbxFilter(cbxFilter, 0, dataGridView1);
        }

        public string getReservationID()
        {
            int index = 1;
            if (reservationBUS.getLength() > 0)
            {
                index = reservationBUS.getAll().Max(item => Functions.convertIdToInteger(item.Id, "RE")) + 1;
            }
            return "RE" + index.ToString("D5");
        }
        #endregion

        #region event
        private void btnAddBook_Click(object sender, EventArgs e)
        {
            string id = getReservationID();
            ReservBookingUI reservBookingUI = new ReservBookingUI(this, id);
            reservBookingUI.Show();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            string id = cbxFilter.Text;

            bindingSource.Filter = @$"
            `ID` like '%{id}%' 
            ";

            dataGridView1.DataSource = bindingSource;
            initCbxFilterAll();
        }
        #endregion
    }
}
