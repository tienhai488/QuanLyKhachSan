using HotelManagement.DAO;
using HotelManagement.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.BUS
{
    public class RoomTypeBUS
    {
        private RoomTypeDAO roomTypeDao = new RoomTypeDAO();

        public List<RoomType2> getAll()
        {
            return roomTypeDao.getAll();
        }

        public int add(RoomType2 roomType)
        {
            return roomTypeDao.AddRoom(roomType);
        }

        public int update(RoomType2 roomType)
        {
            return roomTypeDao.update(roomType);
        }

        public int delete(String id)
        {
            return roomTypeDao.delete(id);
        }

        public String getMaxID()
        {
            return roomTypeDao.getMaxID();
        }


        public bool validateEmpty(RoomType2 roomType)
        {
            StringBuilder sb = new StringBuilder();
            if (roomType.Name.Length == 0)
            {
                sb.Append("Tên loại phòng không được để trống!\n");
            }
            if (roomType.UnitPrice.ToString().Length == 0)
            {
                sb.Append("Giá loại phòng không được để trống!\n");
            }
            if (sb.Length > 0)
            {
                MessageBox.Show(sb.ToString());
                return false;
            }
            return true;
        }

        public bool validate(RoomType2 roomType)
        {
            if (!validateEmpty(roomType))
            {
                return false;
            }
            return true;
        }

        
    }
}
