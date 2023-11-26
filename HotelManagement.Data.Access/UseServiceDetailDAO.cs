namespace HotelManagement.Data.Access
{
    using HotelManagement.Data.Access.Core;

    using Microsoft.EntityFrameworkCore;

    public class UseServiceDetailDAO : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseMySQL(BaseConnection.Connection);

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ServiceType>().ConfigureServiceType();
            modelBuilder.Entity<Service>().ConfigureService();
            modelBuilder.Entity<Customer>().ConfigureCustomer();
            modelBuilder.Entity<Staff>().ConfigureStaff(false, false, false);
            modelBuilder.Entity<Invoice>().ConfigureInvoice();
            modelBuilder.Entity<CancelationStatus>().ConfigureCancelationStatus();
            modelBuilder.Entity<UseServiceDetail>().ConfigureUseServiceDetail();
        }
    }
    public class CancelationStatusEFCoreDAO : UseServiceDetailDAO { }
}
