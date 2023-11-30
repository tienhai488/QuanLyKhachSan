namespace HotelManagement.Data.Access
{
    using HotelManagement.Data.Access.Core;
    using HotelManagement.Data.Transfer;
    using Microsoft.EntityFrameworkCore;

    using System;
    using System.Numerics;

    public class InvoiceDAO : DbContext
    {
        public bool HasStaffId(BigInteger id)
            => (from i in Set<Invoice>()
                where i.StaffID == id
                select i).Any();
        public DbSet<Invoice> Invoices { get; set; }

        public DbSet<RentRoomDetail> RentRoomDetails { get; set; }

        public DbSet<UseServiceDetail> UseServiceDetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseMySQL(BaseConnection.Connection);

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Staff>().ConfigureStaff(false, false, false);

            modelBuilder.Entity<Invoice>()
                .BigIntegerIdProperty(nameof(Invoice.StaffID), "StaffID", "SA", "3");

            modelBuilder.Entity<Invoice>().HasOne(invoice => invoice.Reservation)
                .WithOne(reser => reser.Invoice)
                .HasForeignKey<Invoice>(invoice => invoice.ReservationID);

            modelBuilder.Entity<RentRoomDetail>()
                .BigIntegerIdProperty(nameof(RentRoomDetail.StaffID), "StaffID", "SA", "3");

            modelBuilder.Entity<UseServiceDetail>()
                .BigIntegerIdProperty(nameof(UseServiceDetail.StaffID), "StaffID", "SA", "3");

            modelBuilder.Entity<Reservation>()
                .BigIntegerIdProperty(nameof(Reservation.StaffID), "StaffID", "SA", "3");
        }
    }
}
