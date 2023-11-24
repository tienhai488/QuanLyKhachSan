using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Ultils
{
    public class FormHelpers
    {
        public static void initCbxFilter(ComboBox cbxFilter, int colIndex, DataGridView dataGridView)
        {
            string temp = cbxFilter.Text;
            cbxFilter.Items.Clear();
            if (cbxFilter.DropDownStyle == ComboBoxStyle.DropDownList)
            {
                cbxFilter.Items.Add("");
            }
            else
            {
                temp = "";
            }
            HashSet<string> uniqueValues = new HashSet<string>();

            // Cột muốn hiển thị lên combobox

            // Lặp qua từng dòng trong DataGridView và thêm giá trị vào ComboBox
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.Cells[colIndex].Value != null)
                {
                    string value = row.Cells[colIndex].Value.ToString();

                    // Kiểm tra xem giá trị đã được thêm vào ComboBox chưa
                    if (!uniqueValues.Contains(value))
                    {
                        cbxFilter.Items.Add(value);
                        uniqueValues.Add(value);
                    }
                }
            }

            if(temp != "")
            {
                cbxFilter.Text = temp;  
            }
        }
    }
}
