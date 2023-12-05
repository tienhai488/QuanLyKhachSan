using HotelManagement.Data.Access;
using HotelManagement.Data;
using Microsoft.EntityFrameworkCore;
using HotelManagement.Ultils;
using HotelManagement.Data.Transfer.Ultils;
using Org.BouncyCastle.Asn1.Mozilla;

namespace HotelManagement.Business
{
    public class InvoiceBUS
    {
        private InvoiceDAO invoiceDAO = new InvoiceDAO();

        public List<Invoice> getAll()
        {
            return invoiceDAO.Invoices
                .Include(i => i.Staff)
                .Include(i => i.Customer)
                .Include(i => i.Reservation)
                .AsNoTracking().ToList();
        }
        public int add(Invoice Invoice)
        {
            invoiceDAO.Invoices.Add(Invoice);
            return invoiceDAO.SaveChanges();
        }
        public int getLength()
        {
            return getAll().Count();
        }
    }

    public class RentRoomDetailBUS
    {
        private InvoiceDAO invoiceDAO = new InvoiceDAO();

        public List<RentRoomDetail> getAll()
        {
            return invoiceDAO.RentRoomDetails
                .Include(i => i.Room)
                .Include(i => i.Room.RoomType)
                .Include(i => i.Staff)
                .Include(i => i.Invoice)
                .Include(i => i.Invoice.Customer)
                .Include(i => i.UseServiceDetails)
                .AsNoTracking()
                .ToList();
        }

        public RentRoomDetail getRentRoomById(string rentRoomId)
        {
            return getAll().Find(item => item.Id.Equals(rentRoomId));
        }
        public int add(RentRoomDetail rentRoomDetail)
        {
            invoiceDAO.RentRoomDetails.Add(rentRoomDetail);
            return invoiceDAO.SaveChanges();
        }

        public int update(RentRoomDetail rentRoomDetail)
        {
            invoiceDAO.Entry(rentRoomDetail).State = EntityState.Detached;
            invoiceDAO.RentRoomDetails.Attach(rentRoomDetail);
            invoiceDAO.Entry(rentRoomDetail).State = EntityState.Modified;

            RentRoomDetail temp = invoiceDAO.RentRoomDetails.First(item => item.Id.Equals(rentRoomDetail.Id));
            temp.PaidTime = rentRoomDetail.PaidTime;
            temp.StartTime = rentRoomDetail.StartTime;
            temp.EndTime = rentRoomDetail.EndTime;
            temp.RoomID = rentRoomDetail.RoomID;

            return invoiceDAO.SaveChanges();
        }

        public int getLengthRentRoomDetail()
        {
            return getAll().Count;
        }

        public RentRoomDetail getRentRoomDetail(string roomId, string fromTime, string toTime)
        {
            RentRoomDetail rentRoomDetail = getAll().Find(item => item.RoomID.Equals(roomId)
            && fromTime.Equals(item.StartTime.ToString(Configs.formatBirthday))
            && toTime.Equals(item.EndTime.ToString(Configs.formatBirthday))
            && item.PaidTime == default
            );

            return rentRoomDetail;
        }

        public string getRentRoomDetailId()
        {
            int index = 1;
            if (getLengthRentRoomDetail() > 0)
            {
                index = getAll().Max(item => Functions.convertIdToInteger(item.Id, "RD")) + 1;
            }
            return "RD" + index.ToString("D5");
        }

        public int updateEndTime(string rentRoomId, DateTime endTimeUpdate)
        {
            var item = invoiceDAO.RentRoomDetails.ToList().Find(item => item.Id.Equals(rentRoomId));
            item.EndTime = endTimeUpdate;
            return invoiceDAO.SaveChanges();
        }

        public int updatePaidTime(string rentRoomId)
        {
            var temp = invoiceDAO.RentRoomDetails.ToList().Find(item => item.Id.Equals(rentRoomId));
            if (temp == null)
                return 0;
            temp.PaidTime = DateTime.Now;
            return invoiceDAO.SaveChanges();
        }

        public double getTotalServiceRevenueInMonth(int month, int year)
        {
            double total = 0;
            getAll().Where(item => Functions.equalMonthAndyear(item.PaidTime, month, year))
                .ToList().ForEach(item =>
                {
                    total += getTotalService(item.Id);

                });
            return total;
        }

        public double getTotalService(string rentRoomId)
        {
            double total = 0;
            invoiceDAO.UseServiceDetails.Where(item => item.RentRoomID.Equals(rentRoomId))
                .Include(item => item.Service)
                .ToList()
                .ForEach(item => total += item.Quantity * item.Service.UnitPrice );
            return total;
        }

        public double getTotalRoomRevenueInMonth(int month, int year)
        {
            double total = 0;
            getAll().Where(item => Functions.equalMonthAndyear(item.PaidTime, month, year))
                .ToList().ForEach(item =>
                {
                    int days = Functions.getDayGap(item.StartTime, item.EndTime) + 1;
                    total += days * item.Room.RoomType.UnitPrice;
                });
            return total;
        }

        public int getYearMin()
        {
            if (getAll().Count > 0)
            {
                return getAll().Where(item => item.PaidTime.Year != 1).Min(item => item.PaidTime.Year);
            }
            return DateTime.Now.Year;
        }

        
    }

        
    

    public class UseServiceDetailBUS
    {
        private InvoiceDAO invoiceDAO = new InvoiceDAO();
        public List<UseServiceDetail> getAll()
        {
            return invoiceDAO.UseServiceDetails
                .Include(i => i.Service)
                .Include(i => i.Staff)
                .Include(i => i.RentRoom)
                .AsNoTracking()
                .ToList();
        }

        public List<UseServiceDetail> getServiceByRentRoomID(string rentRoomID)
        {
            return getAll().Where(item => item.RentRoomID.Equals(rentRoomID)).ToList();
        }

        public int addListUseService(List<UseServiceDetail> list)
        {
            invoiceDAO.UseServiceDetails.AddRange(list);
            return invoiceDAO.SaveChanges();
        }

        public int deleteAllUseServiceByRentRoomId(string rentRoomID)
        {
            List<UseServiceDetail> list = invoiceDAO.UseServiceDetails.Where(item => item.RentRoomID.Equals(rentRoomID)).ToList();
            invoiceDAO.RemoveRange(list);
            return invoiceDAO.SaveChanges();
        }

        public int getUseServiceDetailIDInt()
        {
            int index = 1;
            if (getAll().Count > 0)
            {
                index = getAll().Max(item => Functions.convertIdToInteger(item.Id, "SD")) + 1;
            }
            return index;
        }

        public string getUseServiceDetailIDString(int index)
        {
            return "SD" + index.ToString("D5");
        }

        public int getLengthUseServiceById(string serviceId)
        {
            return invoiceDAO.UseServiceDetails.Where(item => item.ServiceID.Equals(serviceId)).Count();
        }

        
    }
}
