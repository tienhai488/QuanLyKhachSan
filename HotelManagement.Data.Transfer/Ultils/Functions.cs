using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Data.Transfer.Ultils
{
    public class Functions
    {
        public static int convertIdToInteger(string id, string seperator)
        {
            string temp = id.Replace(seperator, "");
            return int.Parse(temp);
        }
    }
}
