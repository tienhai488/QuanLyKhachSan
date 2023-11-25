using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.DTO
{
    public class Convinience_RoomType2
    {
        private string convinienceID, roomTypeID;
        private int quantity;

        public Convinience_RoomType2()
        {
        }


        public Convinience_RoomType2(string convinientID, string roomTypeID, int quantity)
        {
            this.ConvinienceID = convinientID;
            this.RoomTypeID = roomTypeID;
            this.Quantity = quantity;
        }

        public Convinience_RoomType2(Convinience_RoomType2 convinience_roomType)
        {
            ConvinienceID = convinience_roomType.ConvinienceID;
            RoomTypeID = convinience_roomType.RoomTypeID;
            Quantity = convinience_roomType.Quantity;
        }


        public string ConvinienceID { get => convinienceID; set => convinienceID = value; }
        public string RoomTypeID { get => roomTypeID; set => roomTypeID = value; }
        public int Quantity { get => quantity; set => quantity = value; }
    }
}
