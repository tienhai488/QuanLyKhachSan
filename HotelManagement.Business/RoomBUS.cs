using HotelManagement.Data;
using HotelManagement.Data.Access;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HotelManagement.BUS
{
    public class RoomBUS
    {

        //------------------------------Room BUS-------------------------------
        private RoomEFCoreDAO roomEFCoreDAO = new RoomEFCoreDAO();

        public List<Room> getAllRoom()
        {
            return roomEFCoreDAO.Rooms.Include(s => s.RoomType).AsNoTracking().ToList();
            //return roomEFCoreDAO.Rooms.Include(s => s.RoomType).AsNoTracking().ToList();
        }

        public Room getRoomById(string id)
        {
            return roomEFCoreDAO.Set<Room>().First(item => item.Id.Equals(id));
        }


        public int addRoom(Room room)
        {
            roomEFCoreDAO.Rooms.Add(room);
            return roomEFCoreDAO.SaveChanges();
        }


        public int updateRoom(Room room)
        {
            roomEFCoreDAO.Entry(room).State = EntityState.Detached;
            roomEFCoreDAO.Rooms.Attach(room);
            roomEFCoreDAO.Entry(room).State = EntityState.Modified;

            Room temp = roomEFCoreDAO.Rooms.First(item => item.Id.Equals(room.Id));
            temp.Status = room.Status;
            temp.RoomType = room.RoomType;

            return roomEFCoreDAO.SaveChanges();
        }

        public int deleteRoom(String id)
        {
            var temp = roomEFCoreDAO.Set<Room>().First(item => item.Id.Equals(id));
            roomEFCoreDAO.Set<Room>().Remove(temp);
            return roomEFCoreDAO.SaveChanges();
        }

        public int getLengthRoom()
        {
            return roomEFCoreDAO.Set<Room>().Count();
        }



        //------------------------------Convinience BUS-------------------------------
        //private ConvinienceDAO convinienceDAO = new ConvinienceDAO();
        private ConvenienceEFCoreDAO convinienceEFCoreDAO = new ConvenienceEFCoreDAO();
        public List<Convinience> getAllConvinience()
        {
            return convinienceEFCoreDAO.Set<Convinience>().AsNoTracking().ToList();
        }


        public Convinience getConvinienceById(string id)
        {
            return convinienceEFCoreDAO.Set<Convinience>().First(item => item.Id.Equals(id));
        }

        public int addConvinience(Convinience convinience)
        {
            convinienceEFCoreDAO.Conviniences.Add(convinience);
            return convinienceEFCoreDAO.SaveChanges();
        }

        public int updateConvinience(Convinience convinience)
        {
            convinienceEFCoreDAO.Entry(convinience).State = EntityState.Detached;
            convinienceEFCoreDAO.Conviniences.Attach(convinience);
            convinienceEFCoreDAO.Entry(convinience).State = EntityState.Modified;

            Convinience temp = convinienceEFCoreDAO.Conviniences.First(item => item.Id.Equals(convinience.Id));
            temp.Name = convinience.Name;

            return convinienceEFCoreDAO.SaveChanges();
        }

        public int deleteConvinience(String id)
        {
            var temp = convinienceEFCoreDAO.Set<Convinience>().First(item => item.Id.Equals(id));
            convinienceEFCoreDAO.Set<Convinience>().Remove(temp);
            return convinienceEFCoreDAO.SaveChanges();
        }

        public int getLengthConvinience()
        {
            return convinienceEFCoreDAO.Set<Convinience>().Count();
        }

        //------------------------------RoomType BUS-------------------------------
        //private RoomTypeDAO roomTypeDao = new RoomTypeDAO();
        private RoomTypeEFCoreDAO roomTypeEFCoreDAO = new RoomTypeEFCoreDAO();

        public List<RoomType> getAllRoomType()
        {
            return roomTypeEFCoreDAO.Set<RoomType>().AsNoTracking().ToList();
        }

        public int addRoomType(RoomType roomType)
        {
            //var temp = new RoomType();
            roomTypeEFCoreDAO.RoomTypes.Add(roomType);
            return roomTypeEFCoreDAO.SaveChanges();
        }

        public int updateRoomType(RoomType roomType)
        {
            var temp = roomTypeEFCoreDAO.Set<RoomType>().First(item => item.Id.Equals(roomType.Id));
            temp.Name = roomType.Name;
            temp.UnitPrice = roomType.UnitPrice;
            return roomTypeEFCoreDAO.SaveChanges();
        }

        public int deleteRoomType(String id)
        {
            var temp = roomTypeEFCoreDAO.Set<RoomType>().First(item => item.Id.Equals(id));
            roomTypeEFCoreDAO.Set<RoomType>().Remove(temp);
            return roomTypeEFCoreDAO.SaveChanges();
        }

        public int getLengthRoomType()
        {
            return roomTypeEFCoreDAO.Set<RoomType>().Count();
        }


        public RoomType getRoomTypeById(string id)
        {
            return roomTypeEFCoreDAO.Set<RoomType>().First(item => item.Id.Equals(id));
        }

        public bool validateEmpty(RoomType roomType)
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

        public bool validate(RoomType roomType)
        {
            if (!validateEmpty(roomType))
            {
                return false;
            }
            return true;
        }


        //------------------------------RoomType_Convinience BUS-------------------------------
        //private Convinience_RoomTypeDAO convinience_roomTypeDAO = new Convinience_RoomTypeDAO();
        
        //private RoomTypeConvinienceEFCoreDAO RoomTypeConvinienceEFCoreDAO = new RoomTypeConvinienceEFCoreDAO();

        public List<RoomTypeConvinience> getAllRoomTypeConvinience()
        {
            return roomTypeEFCoreDAO.Set<RoomTypeConvinience>().AsNoTracking().ToList();
        }

        public int addRoomTypeConvinience(RoomTypeConvinience roomTypeConvenience)
        {
            roomTypeEFCoreDAO.RoomTypeConviniences.Add(roomTypeConvenience);
            return roomTypeEFCoreDAO.SaveChanges();
        }

        public int updateRoomTypeConvinience(RoomTypeConvinience roomTypeConvenience)
        {
            var temp = roomTypeEFCoreDAO.Set<RoomTypeConvinience>().First(item => item.ConvinienceId.Equals(roomTypeConvenience.ConvinienceId) && item.RoomTypeId.Equals(roomTypeConvenience.RoomTypeId));
            temp.Quantity = roomTypeConvenience.Quantity;
            return roomTypeEFCoreDAO.SaveChanges();
        }

        public int deleteRoomTypeConvinience(string convinienceID, string roomTypeID)
        {
            var temp = roomTypeEFCoreDAO.Set<RoomTypeConvinience>().First(item => item.ConvinienceId.Equals(convinienceID) && item.RoomTypeId.Equals(roomTypeID));
            roomTypeEFCoreDAO.Set<RoomTypeConvinience>().Remove(temp);
            return roomTypeEFCoreDAO.SaveChanges();
        }

        public int getLengthRoomTypeConvinience()
        {
            return roomTypeEFCoreDAO.Set<RoomTypeConvinience>().Count();
        }
    }
}
