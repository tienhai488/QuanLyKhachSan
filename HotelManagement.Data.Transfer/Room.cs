namespace HotelManagement.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using Microsoft.EntityFrameworkCore;
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

    [Table("room")]
    public class Room
    {
        [Key]
        [StringLength(50)]
        [Column("ID", TypeName = "varchar")]
        private string id;

        [MaxLength(11)]
        [Column("Status", TypeName = "int")]
        private int status;


        [Column("RoomTypeID", TypeName = "varchar")]
        private string roomTypeId;

        [ForeignKey("RoomTypeID")]
        private RoomType roomType;

        public string Id { get => id; set => id = value; }
        public int Status { get => status; set => status = value; }
        public string RoomTypeId { get => roomTypeId; set => roomTypeId = value; }
        public RoomType RoomType { get => roomType; set => roomType = value; }

        public Room(string id)
        {
            this.Id = id;
        }

        public Room(string id, int status, string roomTypeId)
        {
            this.id = id;
            this.status = status;
            this.roomTypeId = roomTypeId;
        }
        public Room() { }
    }

    [Table("room_type")]
    public class RoomType
    {
        [Key]
        [StringLength(50)]
        [Column("ID", TypeName = "varchar")]
        private string id;

        [StringLength(50)]
        [Column("Name", TypeName = "varchar")]
        private string name;

        [Column("UnitPrice", TypeName = "double")]
        private double unitPrice;

        private IList<Convenience> conveniences;
        private IList<RoomTypeConvenience> quantities;
        private IList<Room> rooms;

        public string Id { get => id; set => id = value; }
        public string Name { get { return name; } set { name = value; } }

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


        public RoomType(string id, string name, double unitPrice)
        {
            this.id = id;
            this.name = name;
            this.unitPrice = unitPrice;
        }
        public RoomType() { }
    }


    [Table("convinience")]
    public class Convenience
    {
        [Key]
        [StringLength(50)]
        [Column("ID", TypeName = "varchar")]
        private string id;

        [StringLength(50)]
        [Column("Name", TypeName = "varchar")]
        private string name;

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }

        public Convenience(string id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
        public Convenience() { }
    }


    [Table("convinience_room_type")]
    [PrimaryKey(nameof(convinienceId), nameof(roomTypeId))]
    public class RoomTypeConvenience
    {
        [StringLength(50)]
        [Column("ConvinienceID", TypeName = "varchar")]
        private string convinienceId;

        
        [ForeignKey("ConvinienceID")]
        private Convenience convinience;

        [StringLength(50)]
        [Column("RoomTypeID", TypeName = "varchar")]
        private string roomTypeId;

        
        [ForeignKey("RoomTypeID")]
        private RoomType roomType;


        [MaxLength(11)]
        [Column("Quantity", TypeName = "int")]
        private int quantity;

        private IList<Convenience> conveniences;


        public string ConvenienceId { get => convinienceId; set => convinienceId = value; }
        public Convenience Convenience { get => convinience; set => convinience = value; }
        public string RoomTypeId { get => roomTypeId; set => roomTypeId = value; }
        public RoomType RoomType { get => roomType; set => roomType = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public IList<Convenience> Conveniences
        {
            get
            {
                var r = conveniences;
                if (r is null) conveniences = r = new List<Convenience>();
                return r;
            }

        }

        public RoomTypeConvenience(string roomTypeId, string convenienceId)
        {
            this.roomTypeId = roomTypeId;
            this.convinienceId = convenienceId;
        }
        public RoomTypeConvenience() { }
    }

    
}
