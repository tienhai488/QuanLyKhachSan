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

        public string Id { get => id; set => id = value; }
        public string CustomerID { get => customerID; set => customerID = value; }
        public BigInteger StaffID { get => staffID; set => staffID = value; }
        public Customer Customer { get => customer; set => customer = value; }
        public Staff Staff { get => staff; set => staff = value; }
        public DateTime CreatedAt { get => createdAt; set => createdAt = value; }
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
        private int status;

        [ForeignKey("RoomID")]
        private Room room;

        [ForeignKey("ReservationID")]
        private Reservation reservation;

        public string RoomID { get => roomID; set => roomID = value; }
        public string ReservationID { get => reservationID; set => reservationID = value; }
        public DateTime StartTime { get => startTime; set => startTime = value; }
        public DateTime EndTime { get => endTime; set => endTime = value; }
        public int Status { get => status; set => status = value; }

        public string getStatusString
        {
            get {
                string value = "";
                if (status == 0) value = "Chưa nhận phòng";
                else if (status == 1) value = "Đã nhận phòng";
                else if (status == 2) value = "Đã hủy đặt";
                return value;
            }
        }
        public Reservation Reservation { get => reservation; set => reservation = value; }
    }

}
