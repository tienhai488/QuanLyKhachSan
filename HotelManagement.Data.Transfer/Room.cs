namespace HotelManagement.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Numerics;
    using System.Text;
    using System.Threading.Tasks;

    public enum RoomStatus : int
    {
        Empty = 0,
        Reserved = 1,
        Rented = 2,
        CleaningUp = 3
    }

    public class Room
    {
        private string id;
        private RoomStatus status;
        private BigInteger? typeId;
        private RoomType roomType;

        public string Id { get => id; private set => id = value; }
        public RoomStatus Status { get => status; set => status = value; }
        public RoomType RoomType { get => roomType; set => roomType = value; }
        public BigInteger? RoomTypeId { get => typeId; set => typeId = value; }
        public Room(string id)
        {
            this.id = id;
        }
        public Room() { }
    }

    public class Convenience
    {
        private BigInteger id;
        private string name;

        public BigInteger Id { get => id; private set => id = value; }
        public string Name { get => name; set => name = value; }
        public Convenience(BigInteger id)
        {
            this.id = id;
        }
        public Convenience() { }
    }

    public class RoomTypeConvenience
    {
        private BigInteger roomTypeId;
        private BigInteger convenienceId;
        private RoomType roomType;
        private Convenience convenience;
        private int quantity;
        public BigInteger RoomTypeId { get => roomTypeId; private set => roomTypeId = value; }
        public BigInteger ConvenienceId { get => convenienceId; private set => convenienceId = value; }
        public RoomType RoomType { get => roomType; set => roomType = value; }
        public Convenience Convenience { get => convenience; set => convenience = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public RoomTypeConvenience(BigInteger roomTypeId, BigInteger convenienceId)
        {
            this.roomTypeId = roomTypeId;
            this.convenienceId = convenienceId;
        }
        public RoomTypeConvenience() { }
    }

    public class RoomType
    {
        private BigInteger id;
        private double unitPrice;
        private string name;
        private IList<Convenience> conveniences;
        private IList<RoomTypeConvenience> quantities;
        private IList<Room> rooms;

        public BigInteger Id { get => id; private set => id = value; }
        public string Name { get => name; set => name = value; }
        public double UnitPrice { get => unitPrice; set => unitPrice = value; }
        public IList<Convenience> Conveniences
        {
            get
            {
                var r = conveniences;
                if (r is null) conveniences = r
                        = new List<Convenience>();
                return r;
            }
        }
        public IList<RoomTypeConvenience> Quantities
        {
            get
            {
                var r = quantities;
                if (r is null) quantities = r
                        = new List<RoomTypeConvenience>();
                return r;
            }
        }
        public IList<Room> Rooms
        {
            get
            {
                var r = rooms;
                if (r is null) rooms = r
                        = new List<Room>();
                return r;
            }
        }
        public RoomType(BigInteger id)
        {
            this.id = id;
        }
        public RoomType() { }
    }
}
