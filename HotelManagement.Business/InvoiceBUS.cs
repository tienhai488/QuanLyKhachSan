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
            return invoiceDAO.Invoices.AsNoTracking().ToList();
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

    }

    public class UseServiceDetail
    {

    }
}
