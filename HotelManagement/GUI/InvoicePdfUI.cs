using iTextSharp.text;
using iTextSharp.text.pdf;
using HotelManagement.Data;
using HotelManagement.Ultils;
using HotelManagement.Data.Transfer.Ultils;
using HotelManagement.BUS;
using System.Collections.Specialized;
using HotelManagement.Business;

namespace HotelManagement.GUI
{
    public partial class InvoicePdfUI : Form
    {
        private int pdfInvoiceId;
        public int PdfInvoiceId { get; set; }

        private RentRoomDetail rentRoomDetailOld = null;

        private RoomBUS roomBUS = new RoomBUS();
        private UseServiceDetailBUS useServiceDetailBUS = new UseServiceDetailBUS();
        private double total = 0;

        public InvoicePdfUI(RentRoomDetail rentRoomDetail)
        {
            InitializeComponent();

            this.rentRoomDetailOld = rentRoomDetail;

            FormatInvoice();
        }

        private void mbtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mbtnPrint_Click(object sender, EventArgs e)
        {
            if(this.rentRoomDetailOld.PaidTime.ToString(Configs.formatBirthday).Equals("01/01/0001")){
                MessageBox.Show("Phiếu thuê chưa được thanh toán! Vui lòng kiểm tra lại!");
                return;
            }
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

            rtbString.Append(String.Format("{0,-40}{1, -39}\n", "FROM", $"INVOICE: {this.rentRoomDetailOld.InvoiceID} - RENTROOMID: {this.rentRoomDetailOld.Id}"));
            rtbString.Append("\n");

            rtbString.Append(String.Format("{0,-40}{1, -39}\n", "THE GRAND BUDAPEST HOTEL", $"StartTime: {this.rentRoomDetailOld.StartTime.ToString(Configs.formatBirthday)}"));
            rtbString.Append(String.Format("{0,-40}{1, -39}\n", "273 An Duong Vuong, Ward 3,", $"EndTime: {this.rentRoomDetailOld.EndTime.ToString(Configs.formatBirthday)}" ));
            rtbString.Append(String.Format("{0,-40}{1, -39}\n", "District 5, Ho Chi Minh City, VN", $"Paid: {this.rentRoomDetailOld.PaidTime.ToString(Configs.formatDateTime)}"));
            rtbString.Append("\n");
            rtbString.Append("-------------------------------------------------------------------------------\n");
            rtbString.Append("\n");

            rtbString.Append(String.Format("{0,-40}\n", "BILL TO"));
            rtbString.Append("\n");

            rtbString.Append(String.Format("{0}\n", $"Customer Name: {this.rentRoomDetailOld.Invoice.Customer.FullName}"));
            rtbString.Append("\n");
            rtbString.Append(String.Format("{0}\n", $"CitizenID: {this.rentRoomDetailOld.Invoice.Customer.CitizenID}"));
            rtbString.Append("\n");
            rtbString.Append(String.Format("{0}\n", $"Phone Number: {this.rentRoomDetailOld.Invoice.Customer.PhoneNumber}"));
            rtbString.Append("\n");
            rtbString.Append(String.Format("{0}\n", $"Address: {this.rentRoomDetailOld.Invoice.Customer.Address}"));
            rtbString.Append("\n");
            rtbString.Append("-------------------------------------------------------------------------------\n");
            rtbString.Append("\n");

            rtbString.Append(String.Format("{0,-6}{1,-19}{2,-20}{3,-12}{4,-10}{5,-12}\n", "No.", "NAME", "DESCRIPTION", "UNIT PRICE", "QUANTITY", "AMOUNT"));
            rtbString.Append("\n");

            Room room = roomBUS.getRoomById(rentRoomDetailOld.RoomID);
            int count = Functions.getDayGap(rentRoomDetailOld.StartTime, rentRoomDetailOld.EndTime) + 1;
            this.total += room.RoomType.UnitPrice * count;
            rtbString.Append(String.Format("{0,-6}{1,-19}{2,-20}{3,-12}{4,-10}{5,-12}\n", "1", room.Id, "Phòng được thuê", $"{room.RoomType.UnitPrice}", $"{count}", (this.total).ToString("N0")+"đ"));
            rtbString.Append("\n");

            int index = 1;
            useServiceDetailBUS.getServiceByRentRoomID(rentRoomDetailOld.Id)
                .ForEach(item =>
                {
                    index++;
                    Service service = item.Service;
                    rtbString.Append(String.Format("{0,-6}{1,-19}{2,-20}{3,-12}{4,-10}{5,-12}\n", $"{index}", service.Name, "", $"{service.UnitPrice}", $"{item.Quantity}", (service.UnitPrice * item.Quantity).ToString("N0")));
                    rtbString.Append("\n");
                    this.total += service.UnitPrice * item.Quantity;
                });



            rtbString.Append("\n");
            rtbString.Append("-------------------------------------------------------------------------------\n");
            rtbString.Append("\n");
            rtbString.Append(String.Format("{0,67}{1,-12}\n", "TOTAL: ", $"{this.total.ToString("N0")}"));

            rtbString.Append("\n");
            rtbString.Append("-------------------------------------------------------------------------------\n");
            rtbString.Append("\n");

            rtbString.Append(String.Format("{0}\n", "So tien viet bang chu: " + toVietnameseDong((int)this.total)));
            rtbString.Append("\n");
            rtbString.Append("\n");
            rtbString.Append("\n");

            rtbString.Append(String.Format("{0,10}{1,-20}{2,19}{3,-30}\n", "", "Customer", "", "Cashier"));
            rtbString.Append(String.Format("{0,10}{1,-20}{2,19}{3,-30}\n", "", $"{this.rentRoomDetailOld.Invoice.Customer.FullName}", "", $"{this.rentRoomDetailOld.Staff.FullName}"));

            richTextBox1.AppendText(rtbString.ToString());

            //rtbString.Append($"{itemName} - {quantity} x ${price:0.00} = ${quantity * price:0.00}", new System.Drawing.Font("Arial", 12, FontStyle.Regular), Color.Black);

        }

        private void FormatInvoice2()
        {

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
    }
}
