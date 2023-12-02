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
    using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

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
        public string Id { get; set; }

        [MaxLength(11)]
        [Column("Status", TypeName = "int")]
        public int Status { get; set; }

        [Column("RoomTypeID", TypeName = "varchar")]
        [ForeignKey(nameof(RoomType))]
        public string RoomTypeId { get; set; }
        public RoomType RoomType { get; set; }

        public Room(string id)
        {
            this.Id = id;
        }

        public Room(string id, int status, string roomTypeId)
        {
            Id = id;
            Status = status;
            RoomTypeId = roomTypeId;
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

        //private IList<Convinience> conviniences;
        //private IList<RoomTypeConvinience> quantities;
        //private IList<Room> rooms;

        public string Id { get => id; set => id = value; }
        public string Name { get { return name; } set { name = value; } }

        public double UnitPrice { get => unitPrice; set => unitPrice = value; }

        //public IList<Convinience> Conviniences
        //{
        //    get
        //    {
        //        var r = conviniences;
        //        if (r is null) conviniences = r
        //                = new List<Convinience>();
        //        return r;
        //    }
        //}
        //public IList<RoomTypeConvinience> Quantities
        //{
        //    get
        //    {
        //        var r = quantities;
        //        if (r is null) quantities = r
        //                = new List<RoomTypeConvinience>();
        //        return r;
        //    }
        //}
        //public IList<Room> Rooms
        //{
        //    get
        //    {
        //        var r = rooms;
        //        if (r is null) rooms = r
        //                = new List<Room>();
        //        return r;
        //    }
        //}


        public RoomType(string id, string name, double unitPrice)
        {
            this.id = id;
            this.name = name;
            this.unitPrice = unitPrice;
        }
        public RoomType() { }
    }


    [Table("convinience")]
    public class Convinience
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

        public Convinience(string id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
        public Convinience() { }
    }


    [Table("convinience_room_type")]
    [PrimaryKey(nameof(ConvinienceId), nameof(RoomTypeId))]
    public class RoomTypeConvinience
    {
        [StringLength(50)]
        [Column("ConvinienceID", TypeName = "varchar")]
        private string convinienceId;


        [ForeignKey("ConvinienceID")]
        private Convinience convinience;

        [StringLength(50)]
        [Column("RoomTypeID", TypeName = "varchar")]
        private string roomTypeId;


        [ForeignKey("RoomTypeID")]
        private RoomType roomType;


        [MaxLength(11)]
        [Column("Quantity", TypeName = "int")]
        private int quantity;

        //private IList<Convinience> conviniences;


        public string ConvinienceId { get => convinienceId; set => convinienceId = value; }
        public Convinience Convinience { get => convinience; set => convinience = value; }
        public string RoomTypeId { get => roomTypeId; set => roomTypeId = value; }
        public RoomType RoomType { get => roomType; set => roomType = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        //public IList<Convinience> Conviniences
        //{
        //    get
        //    {
        //        var r = conviniences;
        //        if (r is null) conviniences = r = new List<Convinience>();
        //        return r;
        //    }

        //}

        public RoomTypeConvinience(string convinienceId, string roomTypeId, int quantity)
        {
            this.convinienceId = convinienceId;
            this.roomTypeId = roomTypeId;
            this.quantity = quantity;
        }
        public RoomTypeConvinience() { }
    }


    
}
