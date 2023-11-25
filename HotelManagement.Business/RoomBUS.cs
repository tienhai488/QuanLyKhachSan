using HotelManagement.DAO;
using HotelManagement.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.BUS
{
    public class RoomBUS
    {
        private RoomDAO roomDao = new RoomDAO();

        public List<Room2> getAll()
        {
            return roomDao.getAll();
        }

        public int add(Room2 room)
        {
            return roomDao.AddRoom(room);
        }

        public int update(Room2 room)
        {
            return roomDao.update(room);
        }

        public int delete(String id)
        {
            return roomDao.delete(id);
        }

        public int getLength()
        {
            return roomDao.getLength();
        }
    }
}
