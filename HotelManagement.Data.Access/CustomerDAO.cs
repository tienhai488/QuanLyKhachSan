namespace HotelManagement.Data.Access
{
    using HotelManagement.Data.Access.Core;

    using Microsoft.EntityFrameworkCore;

    public class CustomerDAO : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseMySQL(BaseConnection.Connection);

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Customer>().ConfigureCustomer();
            //modelBuilder.Entity<Reservation>().ConfigureReservation(includeRoomRelationship: false, includeStaffRelationship: false);
            //modelBuilder.Entity<Invoice>().ConfigureInvoice(includeStaffRelationship: false);
        }
    }
}
