namespace HotelManagement.Data.Access
{
    using HotelManagement.Data.Access.Core;

    using Microsoft.EntityFrameworkCore;

    public class RentRoomDetailDAO : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseMySQL(BaseConnection.Connection);

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Convenience>().ConfigureConvenience();
        //    modelBuilder.Entity<RoomType>().ConfigureRoomType();
        //    modelBuilder.Entity<Room>().ConfigureRoom();
        //    modelBuilder.Entity<Customer>().ConfigureCustomer();
        //    modelBuilder.Entity<Staff>().ConfigureStaff(false, false, false);
        //    modelBuilder.Entity<Invoice>().ConfigureInvoice();
        //    modelBuilder.Entity<RentRoomDetail>().ConfigureRentRoomDetail();
        //}
    }
}
