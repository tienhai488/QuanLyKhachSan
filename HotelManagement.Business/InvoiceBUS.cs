using HotelManagement.Data.Access;
using HotelManagement.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        //public int update(Invoice Invoice)
        //{
        //    invoiceDAO.Entry(Invoice).State = EntityState.Detached;
        //    invoiceDAO.Invoices.Attach(Invoice);
        //    invoiceDAO.Entry(Invoice).State = EntityState.Modified;

        //    Invoice temp = invoiceDAO.Invoices.First(item => item.Id.Equals(Invoice.Id));
        //    temp.

        //    return invoiceDAO.SaveChanges();
        //}

        //public int delete(string id)
        //{
        //    Invoice temp = invoiceDAO.Invoices.First(item => item.Id.Equals(id));
        //    invoiceDAO.Invoices.Remove(temp);

        //    return invoiceDAO.SaveChanges();
        //}
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
                .Include(i => i.Staff)
                .Include(i => i.Invoice)
                .AsNoTracking()
                .ToList();
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
    }
}
