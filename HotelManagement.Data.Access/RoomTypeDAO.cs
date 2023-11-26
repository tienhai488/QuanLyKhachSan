namespace HotelManagement.Data.Access
{
    using HotelManagement.Data.Access.Core;

    using Microsoft.EntityFrameworkCore;

    public class RoomTypeDAO : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseMySQL(BaseConnection.Connection);

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Convinience>().ConfigureConvenience();
        //    modelBuilder.Entity<RoomType>().ConfigureRoomType();
        //    modelBuilder.Entity<Room>().ConfigureRoom();
        //}
    }
}
