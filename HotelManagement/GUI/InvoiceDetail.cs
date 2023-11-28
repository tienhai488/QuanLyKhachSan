using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using HotelManagement.Data;

namespace HotelManagement.GUI
{
    public partial class InvoiceDetail : Form
    {
        int invoiceId;
        public InvoiceDetail()
        {
            InitializeComponent();
            FormatInvoice();
        }

        public void getData(int passId)
        {
            invoiceId = passId;
        }
        private void mbtnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void mbtnPrint_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog() { Filter = "PDF file|*.pdf", ValidateNames = true })
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    iTextSharp.text.Document doc = new iTextSharp.text.Document(PageSize.A5);
                    try
                    {
                        PdfWriter.GetInstance(doc, new FileStream(saveFileDialog.FileName, FileMode.Create));
                        doc.Open();
                        doc.Add(new iTextSharp.text.Paragraph(richTextBox1.Text));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        doc.Close();
                    }
                }
            }
            this.Dispose();
        }

        private void FormatInvoice()
        {
            richTextBox1.Clear();

            // Set font and formatting for the entire invoice
            richTextBox1.SelectionFont = new System.Drawing.Font("Tahoma", 14, FontStyle.Regular);
            richTextBox1.SelectionColor = Color.Black;

            
            AddText("THE GRAND BUDAPEST HOTEL\n\n", new System.Drawing.Font("Baskerville Old Face", 24, FontStyle.Bold), Color.FromArgb(173,20,87));

            AddText($"FROM", new System.Drawing.Font("Tahoma", 14, FontStyle.Bold), Color.Black);

            // Add invoice details
            AddText($"                                                           INVOICE #\t", new System.Drawing.Font("Tahoma", 14, FontStyle.Bold), Color.Black);
            AddText($"IN{invoiceId.ToString("D4")}\n", new System.Drawing.Font("Tahoma", 14, FontStyle.Regular), Color.Black);

            AddText($"THE GRAND BUDAPEST HOTEL", new System.Drawing.Font("Baskerville Old Face", 14, FontStyle.Regular), Color.Black);

            // Add invoice details
            AddText("                    DATE          ", new System.Drawing.Font("Tahoma", 14, FontStyle.Bold), Color.Black);
            AddText(DateTime.Now.ToString("MM/dd/yyyy"), new System.Drawing.Font("Tahoma", 14, FontStyle.Regular), Color.Black);

            AddText($"\n273 An Duong Vuong, Ward 3,\nDistrict 5, Ho Chi Minh City, VN\n\n", new System.Drawing.Font("Baskerville Old Face", 14, FontStyle.Regular), Color.Black);

            AddText($"BILL TO\n", new System.Drawing.Font("Tahoma", 14, FontStyle.Bold), Color.Black);

            AddText("Customer Name: ", new System.Drawing.Font("Tahoma", 14, FontStyle.Bold), Color.Black);
            AddText("John Doe\n", new System.Drawing.Font("Tahoma", 14, FontStyle.Regular), Color.Black);
            AddText("Address: \n", new System.Drawing.Font("Tahoma", 14, FontStyle.Bold), Color.Black);
            AddText("Phone Number: \n", new System.Drawing.Font("Tahoma", 14, FontStyle.Bold), Color.Black);

            // Add line items
            AddText("\nQUANTITY          DESCRIPTION          UNIT PRICE          AMOUNT\n", new System.Drawing.Font("Tahoma", 14, FontStyle.Bold), Color.Black);
            AddLineItem("Item 1", 2, 20.00);
            AddLineItem("Item 2", 3, 15.00);

            // Add total
            AddNewLine();
            AddText("Total: $55.00", new System.Drawing.Font("Tahoma", 14, FontStyle.Bold), Color.Black);
        }

        private void AddText(string text, System.Drawing.Font font, Color color)
        {
            richTextBox1.SelectionFont = font;
            richTextBox1.SelectionColor = color;
            richTextBox1.AppendText(text);
        }

        private void AddNewLine()
        {
            richTextBox1.AppendText(Environment.NewLine);
        }

        private void AddLineItem(string itemName, int quantity, double price)
        {
            AddText($"{itemName} - {quantity} x ${price:0.00} = ${quantity * price:0.00}", new System.Drawing.Font("Arial", 12, FontStyle.Regular), Color.Black);
            AddNewLine();
        }
    }
}
