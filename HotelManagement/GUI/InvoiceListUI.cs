using HotelManagement.Data;
using HotelManagement.Data.Access;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement.GUI
{
    public partial class InvoiceListUI : MaterialForm
    {
        private BindingSource bindingSourceInvoice = new BindingSource();
        private DataTable invoiceTable = new DataTable();

        Staff staff1 = new Staff(001);
        Customer customer1 = new Customer("001", "Đặng Anh Đạt", "Nam", new DateTime(1999, 12, 31), "Phan Thiết", "060202002071", "0932091822");
        Customer customer2 = new Customer("002", "Datxua hay feed", "Nam", new DateTime(1999, 12, 31), "Phan Thiết", "261550471", "0932091822");


        List<RentRoomDetail> rentRooms = new List<RentRoomDetail>();
        List<UseServiceDetail> useServiceDetails = new List<UseServiceDetail>();

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

            invoiceTable.Columns.Add("ID");
            invoiceTable.Columns.Add("Customer ID");
            invoiceTable.Columns.Add("Paid Time");
            invoiceTable.Columns.Add("Subtotal");
            invoiceTable.Columns.Add("Total Due");
            invoiceTable.Columns.Add("Staff ID");
            invoiceTable.Columns.Add("Details");

            initDataLoad();
        }

        public void initDataLoad()
        {
            //invoiceTable.Rows.Clear();
            //dataGridView1.DataSource = null;

            //foreach (Invoice item in getAllInvoice())
            //{
            //    invoiceTable.Rows.Add("IN" + item.Id.ToString("D4"), "CU" + item.CustomerId.ToString("D3"), item.PaidTime, item.Subtotal, item.TotalDue, "SA" + item.StaffId.ToString("D3"), "Chi tiết");
            //}

            //dataGridView1.DataSource = invoiceTable;
            //bindingSourceInvoice.DataSource = invoiceTable;

        }
        public List<Invoice> getAllInvoice()
        {
            List<Invoice> list = new List<Invoice>();
            //Invoice invoice1 = new Invoice(0001, staff1.Id, Int32.Parse(customer1.Id));
            //Invoice invoice2 = new Invoice(0002, staff1.Id, Int32.Parse(customer2.Id));
            //invoice1.PaidTime = DateTime.Now;
            //invoice2.PaidTime = DateTime.Now.AddDays(-10);
            //list.Add(invoice1); list.Add(invoice2);
            return list;
        }

        private void dateTimePickerInvoice_ValueChanged(object sender, EventArgs e)
        {
            invoiceTable.Rows.Clear();

            DateTime selectedDate = dateTimePickerInvoice.Value.Date;

            //foreach (Invoice item in getAllInvoice())
            //{
            //    if (selectedDate >= item.PaidTime.Value.Date)
            //    {
            //        invoiceTable.Rows.Add("IN" + item.Id.ToString("D4"), "CU" + item.CustomerId.ToString("D3"), item.PaidTime, item.Subtotal, item.TotalDue, "SA" + item.StaffId.ToString("D3"), "Chi tiết");
            //    }
            //}

            bindingSourceInvoice.DataSource = invoiceTable;
            dataGridView1.DataSource = bindingSourceInvoice;
        }
        private void mbtnSearch_Click(object sender, EventArgs e)
        {
            if (!mtxtCustomerID.Text.Equals(string.Empty))
            {
                invoiceTable.Rows.Clear();
                //foreach (Invoice item in getAllInvoice())
                //{
                //    if (mtxtCustomerID.Text.Equals("CU" + item.CustomerId.ToString("D3"), StringComparison.OrdinalIgnoreCase))
                //    {
                //        invoiceTable.Rows.Add("IN" + item.Id.ToString("D4"), "CU" + item.CustomerId.ToString("D3"), item.PaidTime, item.Subtotal, item.TotalDue, "SA" + item.StaffId.ToString("D3"), "Chi tiết");
                //    }
                //}

                bindingSourceInvoice.DataSource = invoiceTable;
                dataGridView1.DataSource = bindingSourceInvoice;
            }
            else
            {
                initDataLoad();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                string invoiceId = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString().Substring(2);

                InvoicePdfUI invoicePdf = new InvoicePdfUI();
                invoicePdf.PdfInvoiceId = int.Parse(invoiceId);
                invoicePdf.Show();
            }
        }
    }
}

