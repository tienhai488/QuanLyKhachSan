namespace HotelManagement.Data.Access
{
    using HotelManagement.Data.Access.Core;

    using Microsoft.EntityFrameworkCore;

    public class RoomDAO : DbContext
    {
        public DbSet<Room> Rooms { get; set; }
        public DbSet<RoomType> RoomTypes { get; set; }
        public DbSet<RoomTypeConvinience> RoomTypeConviniences { get; set; }
        public DbSet<Convinience> Conviniences { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseMySQL(BaseConnection.Connection);

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Convinience>().ConfigureConvenience();
        //    modelBuilder.Entity<RoomType>().ConfigureRoomType();
        //    modelBuilder.Entity<Room>().ConfigureRoom();
        //    modelBuilder.Entity<Reservation>().ConfigureReservation(includeStaffRelationship: false, includeCustomerRelationship: false);
        //    modelBuilder.Entity<RentRoomDetail>().ConfigureRentRoomDetail(includeStaffRelationship: false, includeInvoiceRelationship: false);
        //}
    }
}
