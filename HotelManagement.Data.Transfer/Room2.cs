using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.DTO
{
    public class Room2
    {
        private string id;
        private int status;
        private string roomTypeID;

        public Room2(){ }
        public Room2(string id, int status, string roomTypeID)
        {
            this.Id = id;
            this.Status = status;
            this.RoomTypeID = roomTypeID;
        }

        public Room2(Room2 r)
        {
            Id = r.Id;
            Status = r.Status;
            RoomTypeID = r.RoomTypeID;
        }

        public string Id { get => id; set => id = value; }
        public int Status { get => status; set => status = value; }
        public string RoomTypeID { get => roomTypeID; set => roomTypeID = value; }
    }
}
