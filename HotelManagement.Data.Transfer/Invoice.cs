namespace HotelManagement.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Numerics;
    using System.Text;
    using System.Threading.Tasks;

    

    public class RentRoomDetail
    {
        private BigInteger id, roomId, staffId, invoiceId;
        private DateTime startTime, endTime, addedTime;
        private Room room;
        private Staff staff;
        private Invoice invoice;

        public BigInteger Id { get => id; private set => id = value; }
        public BigInteger RoomId { get => roomId; private set => roomId = value; }
        public BigInteger StaffId { get => staffId; private set => staffId = value; }
        public BigInteger InvoiceId { get => invoiceId; private set => invoiceId = value; }

        public DateTime StartTime { get => startTime; set => startTime = value; }
        public DateTime EndTime { get => endTime; set => endTime = value; }
        public DateTime AddedTime { get => addedTime; set => addedTime = value; }
        public Room Room { get => room; set => room = value; }
        public Staff Staff { get => staff; set => staff = value; }
        public Invoice Invoice { get => invoice; set => invoice = value; }
        public RentRoomDetail(BigInteger id, BigInteger roomId, BigInteger staffId, BigInteger invoiceId)
        {
            this.id = id;
            this.roomId = roomId;
            this.staffId = staffId;
            this.invoiceId = invoiceId;
        }
        public RentRoomDetail()
        {

        }
    }

    public class UseServiceDetail
    {
        private BigInteger id, staffId, invoiceId, serviceId;
        private DateTime usedTime;
        private ulong quantity;
        private Service service;
        private Staff staff;
        private Invoice invoice;
        private CancelationStatus cancelationStatus;

        public BigInteger Id { get => id; private set => id = value; }
        public BigInteger StaffId { get => staffId; private set => staffId = value; }
        public BigInteger InvoiceId { get => invoiceId; private set => invoiceId = value; }
        public BigInteger ServiceId { get => serviceId; private set => serviceId = value; }

        public DateTime UsedTime { get => usedTime; set => usedTime = value; }
        public ulong Quantity { get => quantity; set => quantity = value; }
        public Service Service { get => service; set => service = value; }
        public Staff Staff { get => staff; set => staff = value; }
        public Invoice Invoice { get => invoice; set => invoice = value; }
        public CancelationStatus CancelationStatus { get => cancelationStatus; set => cancelationStatus = value; }

        public UseServiceDetail(BigInteger id, BigInteger staffId, BigInteger invoiceId, BigInteger serviceId)
        {
            this.id = id;
            this.staffId = staffId;
            this.invoiceId = invoiceId;
            this.serviceId = serviceId;
        }
        public UseServiceDetail()
        {

        }
    }

    public class Invoice
    {
        private BigInteger id, staffId, customerId;
        private Staff staff;
        private Customer customer;
        private readonly IList<RentRoomDetail> rentRooms;
        private readonly IList<UseServiceDetail> useServices;
        private double subtotal, totalDue;
        private DateTime? paidTime;

        public BigInteger Id { get => id; private set => id = value; }
        public BigInteger StaffId { get => staffId; private set => staffId = value; }
        public BigInteger CustomerId { get => customerId; private set => customerId = value; }

        public Staff Staff { get => staff; set => staff = value; }
        public Customer Customer { get => customer; set => customer = value; }

        public IList<RentRoomDetail> RentRooms => rentRooms;

        public IList<UseServiceDetail> UseServices => useServices;

        public double Subtotal { get => subtotal; set => subtotal = value; }
        public double TotalDue { get => totalDue; set => totalDue = value; }
        public DateTime? PaidTime { get => paidTime; set => paidTime = value; }

        public Invoice(BigInteger id, BigInteger staffId, BigInteger customerId)
        {
            this.id = id;
            this.staffId = staffId;
            this.customerId = customerId;
        }
        public Invoice() { }
    }
}
