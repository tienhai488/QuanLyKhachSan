using HotelManagement.Data.Transfer;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;

namespace HotelManagement.Data
{
    [Table("rent_room_detail")]
    public class RentRoomDetail
    {
        [Key]
        [StringLength(50)]
        [Column("ID", TypeName = "varchar")]
        private string id;

        [Column("AddedTime", TypeName = "datetime")]
        private DateTime addedTime;

        [Column("PaidTime", TypeName = "datetime")]
        private DateTime paidTime;

        [Column("StartTime", TypeName = "datetime")]
        private DateTime startTime;

        [Column("EndTime", TypeName = "datetime")]
        private DateTime endTime;

        [StringLength(50)]
        [Column("RoomID", TypeName = "varchar")]
        private string roomID;

        [ForeignKey("RoomID")]
        private Room room;

        private BigInteger staffID;

        [ForeignKey("StaffID")]
        private Staff staff;

        [StringLength(50)]
        [Column("InvoiceID", TypeName = "varchar")]
        private string invoiceID;

        [ForeignKey("InvoiceID")]
        private Invoice invoice;

        private List<UseServiceDetail> useServiceDetails;

        public string Id { get => id; set => id = value; }
        public string RoomID { get => roomID; set => roomID = value; }
        public Room Room { get => room; set => room = value; }
        public BigInteger StaffID { get => staffID; set => staffID = value; }
        public Staff Staff { get => staff; set => staff = value; }
        public string InvoiceID { get => invoiceID; set => invoiceID = value; }
        public Invoice Invoice { get => invoice; set => invoice = value; }
        public List<UseServiceDetail> UseServiceDetails { get => useServiceDetails; set => useServiceDetails = value; }
        public DateTime AddedTime { get => addedTime; set => addedTime = value; }
        public DateTime PaidTime { get => paidTime; set => paidTime = value; }
        public DateTime StartTime { get => startTime; set => startTime = value; }
        public DateTime EndTime { get => endTime; set => endTime = value; }
    }

    [Table("use_service_detail")]
    public class UseServiceDetail
    {
        [Key]
        [StringLength(50)]
        [Column("ID", TypeName = "varchar")]
        private string id;

        [Column("Quantity", TypeName = "int")]
        private int quantity;

        private BigInteger staffID;

        [ForeignKey("StaffID")]
        private Staff staff;

        [StringLength(50)]
        [Column("RentRoomID", TypeName = "varchar")]
        private string rentRoomID;

        [ForeignKey("RentRoomID")]
        private RentRoomDetail rentRoom;

        [StringLength(50)]
        [Column("ServiceID", TypeName = "varchar")]
        private string serviceID;

        [ForeignKey("ServiceID")]
        private Service service;

        public string Id { get => id; set => id = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public BigInteger StaffID { get => staffID; set => staffID = value; }
        public Staff Staff { get => staff; set => staff = value; }
        public string ServiceID { get => serviceID; set => serviceID = value; }
        public Service Service { get => service; set => service = value; }
        public string RentRoomID { get => rentRoomID; set => rentRoomID = value; }
        public RentRoomDetail RentRoom { get => rentRoom; set => rentRoom = value; }
    }

    [Table("invoice")]
    public class Invoice
    {
        [Key]
        [StringLength(50)]
        [Column("ID", TypeName = "varchar")]
        private string id;

        [StringLength(50)]
        [Column("CustomerID", TypeName = "varchar")]
        private string customerID;

        [ForeignKey("CustomerID")]
        private Customer customer;

        [StringLength(50)]
        [Column("ReservationID", TypeName = "varchar")]
        private string reservationID;

        [ForeignKey("ReservationID")]
        public virtual Reservation Reservation { get; set; }

        private BigInteger staffID;

        [ForeignKey("StaffID")]
        private Staff staff;

        private List<RentRoomDetail> rentRoomDetails;

        public string Id { get => id; set => id = value; }
        public string CustomerID { get => customerID; set => customerID = value; }
        public Customer Customer { get => customer; set => customer = value; }
        public string ReservationID { get => reservationID; set => reservationID = value; }
        //public Reservation Reservation { get => reservation; set => reservation = value; }
        public BigInteger StaffID { get => staffID; set => staffID = value; }
        public Staff Staff { get => staff; set => staff = value; }
        public List<RentRoomDetail> RentRoomDetails { get => rentRoomDetails; set => rentRoomDetails = value; }
    }
}
