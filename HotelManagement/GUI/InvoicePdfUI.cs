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
using Microsoft.Extensions.Primitives;

namespace HotelManagement.GUI
{
    public partial class InvoicePdfUI : Form
    {
        private int pdfInvoiceId;
        public int PdfInvoiceId { get; set; }

        Customer customer;
        Invoice invoice;
        Staff staff;
        UseServiceDetail useServiceDetail;
        RentRoomDetailUI roomDetail;
        IList<UseServiceDetail> useServiceDetails;
        IList<RentRoomDetailUI> rentRoomDetails;

        public InvoicePdfUI()
        {
            InitializeComponent();
            createData();
            FormatInvoice();
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
                    iTextSharp.text.Document doc = new iTextSharp.text.Document(PageSize.A4);
                    try
                    {
                        PdfWriter.GetInstance(doc, new FileStream(saveFileDialog.FileName, FileMode.Create));
                        doc.Open();

                        foreach (var paragraph in richTextBox1.Lines)
                        {
                            doc.Add(new iTextSharp.text.Paragraph(new iTextSharp.text.Chunk(paragraph + "\n", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.COURIER, 11))));

                        }
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
            var rtbString = new System.Text.StringBuilder();

            richTextBox1.SelectionFont = new System.Drawing.Font("Lucida Console", 11, FontStyle.Regular); // Adjust the font size and style as needed
            rtbString.Append("\n");
            rtbString.Append(String.Format("{0,52}", "THE GRAND BUDAPEST HOTEL\n"));
            rtbString.Append("\n");
            rtbString.Append(String.Format("{0,53}", "sea to the sky... fly here\n"));
            rtbString.Append("\n");
            rtbString.Append(String.Format("{0,52}", "------------------------\n"));
            rtbString.Append("\n");

            rtbString.Append(String.Format("{0,-40}{1, -39}\n", "FROM", "INVOICE# IN" + pdfInvoiceId.ToString("D4")));
            rtbString.Append("\n");

            rtbString.Append(String.Format("{0,-40}{1, -39}\n", "THE GRAND BUDAPEST HOTEL", "DATE: " + DateTime.Now.ToString("dd/MM/yyyy")));
            rtbString.Append(String.Format("{0,-40}{1, -39}\n", "273 An Duong Vuong, Ward 3,", "TIME: " + DateTime.Now.ToString("HH:mm:ss")));
            rtbString.Append(String.Format("{0,-40}{1, -39}\n", "District 5, Ho Chi Minh City, VN", "STAFF: Ngộ Không"));
            rtbString.Append("\n");
            rtbString.Append("-------------------------------------------------------------------------------\n");
            rtbString.Append("\n");

            rtbString.Append(String.Format("{0,-40}\n", "BILL TO"));
            rtbString.Append("\n");

            rtbString.Append(String.Format("{0}\n", "Customer Name: " + "John Doe"));
            rtbString.Append(String.Format("{0}\n", "Address: " + "John Doe"));
            rtbString.Append(String.Format("{0}\n", "Phone Number: " + "John Doe"));
            rtbString.Append("\n");
            rtbString.Append("-------------------------------------------------------------------------------\n");
            rtbString.Append("\n");

            rtbString.Append(String.Format("{0,-6}{1,-9}{2,-30}{3,-12}{4,-10}{5,-12}\n", "No.", "ID", "DESCRIPTION", "UNIT PRICE", "QUANTITY", "AMOUNT"));
            rtbString.Append("\n");

            rtbString.Append("\n");
            rtbString.Append("-------------------------------------------------------------------------------\n");
            rtbString.Append("\n");
            rtbString.Append(String.Format("{0,67}{1,-12}\n", "TOTAL: ", "999_999_000"));

            rtbString.Append("\n");
            rtbString.Append("-------------------------------------------------------------------------------\n");
            rtbString.Append("\n");

            rtbString.Append(String.Format("{0}\n", "So tien viet bang chu: " + toVietnameseDong(0)));
            rtbString.Append("\n");
            rtbString.Append("\n");
            rtbString.Append("\n");

            rtbString.Append(String.Format("{0,20}{1,39}{2,-20}\n", "Customer", "", "Cashier"));
            rtbString.Append(String.Format("{0,30}{1,19}{2,-30}\n", "(Signature and full name)", "", "(Signature and full name)"));

            richTextBox1.AppendText(rtbString.ToString());

            //rtbString.Append($"{itemName} - {quantity} x ${price:0.00} = ${quantity * price:0.00}", new System.Drawing.Font("Arial", 12, FontStyle.Regular), Color.Black);

        }

        private string toVietnameseDong(int totalPrice)
        {
            if (totalPrice == 0) return "Khong VND";

            string[] ones = { "", "Mot", "Hai", "Ba", "Bon", "Nam", "Sau", "Bay", "Tam", "Chin", "Muoi", "Muoi Mot", "Muoi Hai", "Muoi Ba", "Muoi Bon", "Muoi Lam", "Muoi Sau", "Muoi Bay", "Muoi Tam", "Muoi Chin" };
            string[] tens = { "", "", "Hai Muoi", "Ba Muoi", "Bon Muoi", "Nam Muoi", "Sau Muoi", "Bay Muoi", "Tam Muoi", "Chin Muoi" };
            string[] thousands = { "", "Nghin", "Trieu", "Ti" };

            string ConvertToVietnameseDongs(int number)
            {
                if (number == 0) return "";
                else if (number < 10) return ones[number] + "";
                else if (number < 20) return ones[number] + " Muoi ";
                else if (number < 100) return tens[number / 10] + " " + ConvertToVietnameseDongs(number % 10);
                else return ones[number / 100] + " Tram " + ConvertToVietnameseDongs(number % 100);
            }

            int index = 0;
            string words = "";

            while (totalPrice > 0)
            {
                if (totalPrice % 1000 != 0)
                    words = $"{ConvertToVietnameseDongs(totalPrice % 1000)} {thousands[index]} {words}";

                totalPrice /= 1000;
                index++;
            }

            return $"{words.Trim()} VND";
        }

        public void createData()
        {
            customer = new Customer("001", "Đặng Anh Đạt", "Nam", new DateTime(1999, 1, 1), "Phan Thiết", "060202002071", "0932091822");
            staff = new Staff(001);
            return;
        }
    }
}
