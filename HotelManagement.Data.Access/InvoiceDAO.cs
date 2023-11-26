namespace HotelManagement.Data.Access
{
    using HotelManagement.Data.Access.Core;

    using Microsoft.EntityFrameworkCore;

    public class InvoiceDAO : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseMySQL(BaseConnection.Connection);

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().ConfigureCustomer();
            modelBuilder.Entity<Staff>().ConfigureStaff(false, false, false);
            modelBuilder.Entity<Invoice>().ConfigureInvoice();

            modelBuilder.Entity<Service>().ConfigureService(false);
            modelBuilder.Entity<UseServiceDetail>().ConfigureUseServiceDetail();
            modelBuilder.Entity<CancelationStatus>().ConfigureCancelationStatus();

            modelBuilder.Entity<RoomType>().ConfigureRoomType(false);
            modelBuilder.Entity<Room>().ConfigureRoom();
            modelBuilder.Entity<RentRoomDetail>().ConfigureRentRoomDetail();
        }
    }
}
