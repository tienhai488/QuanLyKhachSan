using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Ultils
{
    public class ValidationCustom
    {
        public static Boolean checkDouble(string temp)
        {
            if(Double.TryParse(temp, out var result))
            {
                return result >= 0;
            }
            return false;
        }
    }
}
