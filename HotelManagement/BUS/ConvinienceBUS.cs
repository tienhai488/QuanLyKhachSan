using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelManagement.DAO;
using HotelManagement.DTO;
using HotelManagement.Ultils;
using static System.Net.Mime.MediaTypeNames;

namespace HotelManagement.BUS
{
    public class ConvinienceBUS
    {
       private ConvinienceDAO convinienceDAO = new ConvinienceDAO();
        public List<Convinience> getAllValue()
        {
            return convinienceDAO.getAllvalue();
        }
        public List<Convinience_Room_Type> getAllTypevalue()
        {
            return convinienceDAO.getAllTypevalue();
        }    
        public int addConvinience(Convinience convinience)
        {
            return convinienceDAO.addConvinience(convinience);
        }
        public int addCRT(Convinience_Room_Type convinience)
        {
            return convinienceDAO.addCRT(convinience);
        }
        public int updateConvinience(Convinience convinience)
        {
            return convinienceDAO.updateConvinience(convinience);   
        }
        public int updateCRT(Convinience_Room_Type convinience)
        {
            return convinienceDAO.updateCRT(convinience);
        }
        public int deleteConvinience(string tentn) 
        {
            return convinienceDAO.deleteConvinience(tentn);
        }
        public int deleteCRT(string matn,string maphong)
        {
            return convinienceDAO.deleteCRT(matn,maphong);
        }
        public int getLengthConvinience()
        {
            return convinienceDAO.getLengthConvinience();
        }
        public int getLengthCRT()
        {
            return convinienceDAO.getLengthCRT();
        }
        public bool validateEmptyConvinience(string matn,string tentn)
        {
            StringBuilder tb = new StringBuilder();
            if(matn.Length == 0)
            {
                tb.Append("Mã tiện nghi không được để trống");
            }
            if(tentn.Length == 0)
            {
                tb.Append("Tên tiện nghi không được để trống");
            }
            if(tb.Length > 0)
            {
                MessageBox.Show(tb.ToString());
                return false;
            }
            return true;
        }
        public bool validateConvinience(string matn, string tentn)
        {
            if(!validateEmptyConvinience(matn, tentn))
            {
                return false;
            }
            StringBuilder tb = new StringBuilder();
            if(Double.TryParse(matn, out double d))
            {
                tb.Append("Mã tiện nghi không hợp lệ! Vui lòng nhập lại.");
            } 
            if(Double.TryParse(tentn,out double e))
            {
                tb.Append("Tên tiện nghi không hợp lệ! Vui lòng nhập lại.");
            }
            if (tb.Length > 0)
            {
                MessageBox.Show(tb.ToString());
                return false;
            }
            return true;
        }
        public bool validateEmptyCRT(string matn, string maphong, int soluong)
        {
            StringBuilder tb = new StringBuilder();
            if(matn.Length == 0) 
            {
                tb.Append("Mã tiện nghi không được để trống");
            }
            if(maphong.Length == 0)
            {
                tb.Append("Mã phòng không được để trống");
            }
            if(soluong.ToString().Length == 0)
            {
                tb.Append("Số lượng tiện nghi không được để trống");
            }
            if (tb.Length > 0)
            {
                MessageBox.Show(tb.ToString());
                return false;
            }
            return true;
        }
        public bool validateCRT(string matn,string maphong,int soluong)
        {
            if (!validateEmptyCRT(matn, maphong, soluong))
            {
                return false;
            }
            StringBuilder tb = new StringBuilder();
            if (Double.TryParse(matn, out double d))
            {
                tb.Append("Mã tiện nghi không hợp lệ! Vui lòng nhập lại.");
            }
            if (Double.TryParse(maphong, out double e))
            {
                tb.Append("Mã phòng không hợp lệ! Vui lòng nhập lại.");
            }
            if(!int.TryParse(soluong.ToString(), out int i))
            {
                tb.Append("Số lượng không hợp lệ! Vui lòng nhập lại.");
            }
            if (tb.Length > 0)
            {
                MessageBox.Show(tb.ToString());
                return false;
            }
            return true;
        }

    }
}
