using HotelManagement.Ultils;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace HotelManagement.Data.Transfer.Ultils
{
    public class Functions
    {
        public static int convertIdToInteger(string id, string seperator)
        {
            string temp = id.Replace(seperator, "");
            return int.Parse(temp);
        }

        public static int getDayGap(DateTime from, DateTime to)
        {
            DateTime startDate = new DateTime(from.Year, from.Month, from.Day);
            // Ngày kết thúc
            DateTime endDate = new DateTime(to.Year, to.Month, to.Day);
            return endDate.Subtract(startDate).Days;
        }

        public static DateTime convertStringToDateTime(string str)
        {
            return DateTime.ParseExact(str, Configs.formatBirthday, CultureInfo.InvariantCulture, DateTimeStyles.None);
        }
    }
}
