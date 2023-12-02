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
        public string Id { get; set; }

        [Column("CreatedAt", TypeName = "datetime")]
        public DateTime CreatedAt { get; set; }

        [StringLength(50)]
        [Column("CustomerID", TypeName = "varchar")]
        [ForeignKey(nameof(Customer))]
        public string CustomerID { get; set; }

        public BigInteger StaffID { get; set; }

        public Customer Customer { get; set; }

        [ForeignKey(nameof(StaffID))]
        public Staff Staff { get; set; }

        public virtual Invoice Invoice { get; set; }
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
    public class RoomReservation
    {
        [Key]
        [StringLength(50)]
        [Column("ID", TypeName = "varchar")]
        public string Id { get; set; }

        [StringLength(50)]
        [Column("RoomID", TypeName = "varchar")]
        [ForeignKey(nameof(Room))]
        public string RoomId { get; set; }

        [StringLength(50)]
        [Column("ReservationID", TypeName = "varchar")]
        [ForeignKey(nameof(Reservation))]
        public string ReservationId { get; set; }

        [Column("StartTime", TypeName = "date")]
        public DateTime StartTime { get; set; }

        [Column("EndTime", TypeName = "date")]
        public DateTime EndTime { get; set; }

        [MaxLength(11)]
        [Column("Status", TypeName = "int")]
        public RoomReservationStatus Status { get; set; }

        public Room Room { get; set; }

        public Reservation Reservation { get; set; }

        static public string getStatusString(RoomReservationStatus roomReservationStatus)
        {
            return Enum.GetName(roomReservationStatus); // như thế này??
            string value = "";
            if (roomReservationStatus == RoomReservationStatus.Booked) value = "Booked";
            else if (roomReservationStatus == RoomReservationStatus.Rented) value = "Rented";
            else if (roomReservationStatus == RoomReservationStatus.OutDate) value = "OutDate";
            else if (roomReservationStatus == RoomReservationStatus.Paid) value = "Paid";
            else if (roomReservationStatus == RoomReservationStatus.All) value = "All";
            else if (roomReservationStatus == RoomReservationStatus.Empty) value = "Empty";
            return value; // còn tiếng việt thì làm kiểu này
        }

        static public RoomReservationStatus getStatusEnum(string statusString)
        {

            if (!Enum.TryParse(statusString.Trim(), out RoomReservationStatus status))
            {
                status = RoomReservationStatus.Booked;
            }
            return status; // như thế này??
            statusString = statusString.Trim();
            if (statusString.Equals("Rented")) return RoomReservationStatus.Rented;
            else if (statusString.Equals("OutDate")) return RoomReservationStatus.OutDate;
            else if (statusString.Equals("Paid")) return RoomReservationStatus.Paid;
            else if (statusString.Equals("All")) return RoomReservationStatus.All;
            else if (statusString.Equals("Empty")) return RoomReservationStatus.Empty;
            return RoomReservationStatus.Booked;
        }
    }

}
