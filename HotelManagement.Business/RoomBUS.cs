using Google.Protobuf.WellKnownTypes;
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
        private RoomDAO roomEFCoreDAO = new RoomDAO();

        public List<Room> getAllRoom()
        {
            return roomEFCoreDAO.Rooms.Include(s => s.RoomType).AsNoTracking().ToList();
            //return roomEFCoreDAO.Rooms.Include(s => s.RoomType).AsNoTracking().ToList();
        }

        public Room getRoomById(string id)
        {
            return getAllRoom().First(item => item.Id.Equals(id));
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
            var temp = roomEFCoreDAO.Rooms.First(item => item.Id.Equals(id));
            roomEFCoreDAO.Rooms.Remove(temp);
            return roomEFCoreDAO.SaveChanges();
        }

        public int getLengthRoom()
        {
            return roomEFCoreDAO.Rooms.Count();
        }

        public List<Room> getAllCleanedRoom()
        {
            return getAllRoom().Where(item =>item.Status==0).ToList();
        }

        public int convertStringToRoomStatus(string value)
        {
            int result = -1;
            if (value == "Cleaned")
                result = 0;
            else if (value == "NotCleanedYet")
                result = 1;
            else if (value == "Maintaining")
                result = 2;
            return result;
        }

        public string convertRoomStatusToString(int status)
        {
            string result = "All";
            if (status == 0)
                result = "Cleaned";
            else if (status == 1)
                result = "NotCleanedYet";
            else if (status == 2)
                result = "Maintaining";

            return result;
        }





        //------------------------------Convinience BUS-------------------------------
        //private ConvinienceDAO convinienceDAO = new ConvinienceDAO();
        //private ConvenienceEFCoreDAO convinienceEFCoreDAO = new ConvenienceEFCoreDAO();
        public List<Convinience> getAllConvinience()
        {
            return roomEFCoreDAO.Conviniences.AsNoTracking().ToList();
        }


        public Convinience getConvinienceById(string id)
        {
            return roomEFCoreDAO.Conviniences.First(item => item.Id.Equals(id));
        }

        public int addConvinience(Convinience convinience)
        {
            roomEFCoreDAO.Conviniences.Add(convinience);
            return roomEFCoreDAO.SaveChanges();
        }

        public int updateConvinience(Convinience convinience)
        {
            Convinience temp = roomEFCoreDAO.Conviniences.First(item => item.Id.Equals(convinience.Id));
            temp.Name = convinience.Name;

            return roomEFCoreDAO.SaveChanges();
        }

        public int deleteConvinience(String id)
        {
            var temp = roomEFCoreDAO.Conviniences.First(item => item.Id.Equals(id));
            roomEFCoreDAO.Conviniences.Remove(temp);
            return roomEFCoreDAO.SaveChanges();
        }

        public int getLengthConvinience()
        {
            return roomEFCoreDAO.Conviniences.Count();
        }

        //------------------------------RoomType BUS-------------------------------
        //private RoomTypeDAO roomTypeDao = new RoomTypeDAO();
        //private RoomTypeEFCoreDAO roomTypeEFCoreDAO = new RoomTypeEFCoreDAO();

        public List<RoomType> getAllRoomType()
        {
            return roomEFCoreDAO.RoomTypes.AsNoTracking().ToList();
        }

        public int addRoomType(RoomType roomType)
        {
            //var temp = new RoomType();
            roomEFCoreDAO.RoomTypes.Add(roomType);
            return roomEFCoreDAO.SaveChanges();
        }

        public int updateRoomType(RoomType roomType)
        {

            var temp = roomEFCoreDAO.RoomTypes.First(item => item.Id.Equals(roomType.Id));
            temp.Name = roomType.Name;
            temp.UnitPrice = roomType.UnitPrice;
            roomEFCoreDAO.Update(temp);
            return roomEFCoreDAO.SaveChanges();
        }

        public int deleteRoomType(String id)
        {
            var temp = roomEFCoreDAO.RoomTypes.First(item => item.Id.Equals(id));
            roomEFCoreDAO.RoomTypes.Remove(temp);
            return roomEFCoreDAO.SaveChanges();
        }

        public int getLengthRoomType()
        {
            return roomEFCoreDAO.RoomTypes.Count();
        }


        public RoomType getRoomTypeById(string id)
        {
            return roomEFCoreDAO.RoomTypes.First(item => item.Id.Equals(id));
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
            return roomEFCoreDAO.RoomTypeConviniences.AsNoTracking().ToList();
        }

        public int addRoomTypeConvinience(RoomTypeConvinience roomTypeConvenience)
        {
            roomEFCoreDAO.RoomTypeConviniences.Add(roomTypeConvenience);
            roomEFCoreDAO.ChangeTracker.DetectChanges();
            return roomEFCoreDAO.SaveChanges();
        }

        public int updateRoomTypeConvinience(RoomTypeConvinience roomTypeConvenience)
        {
            var temp = roomEFCoreDAO.RoomTypeConviniences.First(item => item.ConvinienceId.Equals(roomTypeConvenience.ConvinienceId) && item.RoomTypeId.Equals(roomTypeConvenience.RoomTypeId));
            temp.Quantity = roomTypeConvenience.Quantity;
            return roomEFCoreDAO.SaveChanges();
        }

        public int deleteRoomTypeConvinience(string convinienceID, string roomTypeID)
        {
            var temp = roomEFCoreDAO.RoomTypeConviniences.First(item => item.ConvinienceId.Equals(convinienceID) && item.RoomTypeId.Equals(roomTypeID));
            roomEFCoreDAO.RoomTypeConviniences.Remove(temp);
            return roomEFCoreDAO.SaveChanges();
        }

        public int getLengthRoomTypeConvinience()
        {
            return roomEFCoreDAO.RoomTypeConviniences.Count();
        }
    }
}
