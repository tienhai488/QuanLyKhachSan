using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Data.Transfer
{
    [Table("reservation")]
    public class Reservation
    {
        [Key]
        [StringLength(50)]
        [Column("ID", TypeName = "varchar")]
        private string id;

        [Column("CreatedAt", TypeName = "datetime")]
        private DateTime createdAt;

        [StringLength(50)]
        [Column("CustomerID", TypeName = "varchar")]
        private string customerID;

        private BigInteger staffID;

        [ForeignKey("CustomerID")]
        private Customer customer;

        [ForeignKey("StaffID")]
        private Staff staff;

        [ForeignKey("ID")]
        public virtual Invoice Invoice { get; set; }

        public string Id { get => id; set => id = value; }
        public string CustomerID { get => customerID; set => customerID = value; }
        public BigInteger StaffID { get => staffID; set => staffID = value; }
        public Customer Customer { get => customer; set => customer = value; }
        public Staff Staff { get => staff; set => staff = value; }
        public DateTime CreatedAt { get => createdAt; set => createdAt = value; }
        //public Invoice Invoice { get => invoice; set => invoice = value; }
    }

    public enum RoomReservationStatus : int
    {
        All = -1,
        Booked = 0,
        Rented = 1,
        OutDate = 2,
        Paid = 3,
        Empty = 4
    }

    [Table("room_reservation")]
    [PrimaryKey(nameof(RoomID), nameof(ReservationID))]
    public class RoomReservation
    {
        [StringLength(50)]
        [Column("RoomID", TypeName = "varchar")]
        private string roomID;

        [StringLength(50)]
        [Column("ReservationID", TypeName = "varchar")]
        private string reservationID;

        [Column("StartTime", TypeName = "date")]
        private DateTime startTime;

        [Column("EndTime", TypeName = "date")]
        private DateTime endTime;

        [MaxLength(11)]
        [Column("Status", TypeName = "int")]
        private RoomReservationStatus status;

        [ForeignKey("RoomID")]
        private Room room;

        [ForeignKey("ReservationID")]
        private Reservation reservation;

        public string RoomID { get => roomID; set => roomID = value; }
        public string ReservationID { get => reservationID; set => reservationID = value; }
        public DateTime StartTime { get => startTime; set => startTime = value; }
        public DateTime EndTime { get => endTime; set => endTime = value; }

        static public string getStatusString(RoomReservationStatus roomReservationStatus)
        {
            string value = "";
            if (roomReservationStatus == RoomReservationStatus.Booked) value = "Booked";
            else if (roomReservationStatus == RoomReservationStatus.Rented) value = "Rented";
            else if (roomReservationStatus == RoomReservationStatus.OutDate) value = "OutDate";
            else if (roomReservationStatus == RoomReservationStatus.Paid) value = "Paid";
            else if (roomReservationStatus == RoomReservationStatus.All) value = "All";
            else if (roomReservationStatus == RoomReservationStatus.Empty) value = "Empty";
            return value;
        }

        static public RoomReservationStatus getStatusEnum(string statusString)
        {
            statusString = statusString.Trim();
            if(statusString.Equals("Rented")) return RoomReservationStatus.Rented;
            else if(statusString.Equals("OutDate")) return RoomReservationStatus.OutDate;
            else if(statusString.Equals("Paid")) return RoomReservationStatus.Paid;
            else if(statusString.Equals("All")) return RoomReservationStatus.All;
            else if(statusString.Equals("Empty")) return RoomReservationStatus.Empty;
            return RoomReservationStatus.Booked;
        }
        public Reservation Reservation { get => reservation; set => reservation = value; }
        public Room Room { get => room; set => room = value; }
        public RoomReservationStatus Status { get => status; set => status = value; }
    }

}
