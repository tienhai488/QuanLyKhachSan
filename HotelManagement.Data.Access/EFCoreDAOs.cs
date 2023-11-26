namespace HotelManagement.Data.Access
{
    using HotelManagement.Data.Access.Core;

    using Microsoft.EntityFrameworkCore;

    using MySql.EntityFrameworkCore.Infrastructure;

    using System.Numerics;

    public class CustomerEFCoreDAO : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL(BaseConnection.Connection, OnConfiguringMySQL);
        }

        private void OnConfiguringMySQL(MySQLDbContextOptionsBuilder builder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Customer>().ConfigureCustomer();
            //modelBuilder.Entity<Reservation>().ConfigureReservation(includeRoomRelationship: false, includeStaffRelationship: false);
            //modelBuilder.Entity<Invoice>().ConfigureInvoice(includeStaffRelationship: false);
        }
    }
    public class ReservationEFCoreDAO : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL(BaseConnection.Connection, OnConfiguringMySQL);
        }

        private void OnConfiguringMySQL(MySQLDbContextOptionsBuilder builder)
        {
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Convenience>().ConfigureConvenience();
        //    modelBuilder.Entity<RoomType>().ConfigureRoomType();
        //    modelBuilder.Entity<Room>().ConfigureRoom();
        //    modelBuilder.Entity<Customer>().ConfigureCustomer();
        //    modelBuilder.Entity<Staff>().ConfigureStaff(false, false, false);
        //    modelBuilder.Entity<Reservation>().ConfigureReservation();
        //}
    }
    public class RentRoomDetailEFCoreDAO : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL(BaseConnection.Connection, OnConfiguringMySQL);
        }

        private void OnConfiguringMySQL(MySQLDbContextOptionsBuilder builder)
        {
        }

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
    public class UseServiceDetailEFCoreDAO : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL(BaseConnection.Connection, OnConfiguringMySQL);
        }

        private void OnConfiguringMySQL(MySQLDbContextOptionsBuilder builder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ServiceType>().ConfigureServiceType();
            modelBuilder.Entity<Service>().ConfigureService();
            modelBuilder.Entity<Customer>().ConfigureCustomer();
            modelBuilder.Entity<Staff>().ConfigureStaff(false, false, false);
            modelBuilder.Entity<Invoice>().ConfigureInvoice();
            modelBuilder.Entity<UseServiceDetail>().ConfigureUseServiceDetail();
            modelBuilder.Entity<CancelationStatus>().ConfigureCancelationStatus();
        }
    }
    public class InvoiceEFCoreDAO : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL(BaseConnection.Connection, OnConfiguringMySQL);
        }

        private void OnConfiguringMySQL(MySQLDbContextOptionsBuilder builder)
        {
        }

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
    public class AccountEFCoreDAO : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL(BaseConnection.Connection, OnConfiguringMySQL);
        }

        private void OnConfiguringMySQL(MySQLDbContextOptionsBuilder builder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>().ConfigureAccount();
        }

        public IEnumerable<Account> NormalAccounts
            => from a in Set<Account>() where a.Uid != BigInteger.Zero select a;

        public BigInteger UsableUid
        {
            get
            {
                IEnumerable<Account> accounts = NormalAccounts.ToList();
                return (from a in accounts
                        let uids = from b in accounts
                                   join c in accounts
                                   on b.Uid + 1 equals c.Uid
                                   select b.Uid
                        where !uids.Contains(a.Uid)
                        select a.Uid).FirstOrDefault(0) + 1;
            }
        }
    }
    public class PermissionGroupEFCoreDAO : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL(BaseConnection.Connection, OnConfiguringMySQL);
        }

        private void OnConfiguringMySQL(MySQLDbContextOptionsBuilder builder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PermissionGroup>().ConfigurePermissionGroup();
            modelBuilder.Entity<Staff>().ConfigureStaff(includeRoleRelationship: false, includeAccountRelationship: false);
        }
    }
    public class RoomEFCoreDAO : DbContext
    {
        public DbSet<Room> Rooms { get; set; }
        public DbSet<RoomTypeConvinience> RoomTypeConveniences { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL(BaseConnection.Connection, OnConfiguringMySQL);
        }

        private void OnConfiguringMySQL(MySQLDbContextOptionsBuilder builder)
        {
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Convenience>().ConfigureConvenience();
        //    modelBuilder.Entity<RoomType>().ConfigureRoomType();
        //    modelBuilder.Entity<Room>().ConfigureRoom();
        //    modelBuilder.Entity<Reservation>().ConfigureReservation(includeStaffRelationship: false, includeCustomerRelationship: false);
        //    modelBuilder.Entity<RentRoomDetail>().ConfigureRentRoomDetail(includeStaffRelationship: false, includeInvoiceRelationship: false);
        //}
    }
    public class ConvenienceEFCoreDAO : DbContext
    {
        public DbSet<Convinience> Conviniences { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL(BaseConnection.Connection, OnConfiguringMySQL);
        }

        private void OnConfiguringMySQL(MySQLDbContextOptionsBuilder builder)
        {
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Convenience>().ConfigureConvenience();
        //    modelBuilder.Entity<RoomType>().ConfigureRoomType();
        //}
    }
    public class RoomTypeEFCoreDAO : DbContext
    {
        public DbSet<RoomType> RoomTypes { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL(BaseConnection.Connection, OnConfiguringMySQL);
        }

        private void OnConfiguringMySQL(MySQLDbContextOptionsBuilder builder)
        {
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Convenience>().ConfigureConvenience();
        //    modelBuilder.Entity<RoomType>().ConfigureRoomType();
        //    modelBuilder.Entity<Room>().ConfigureRoom();
        //}
    }

    public class CancelationStatusEFCoreDAO : UseServiceDetail { }
    public class ServiceEFCoreDAO : DbContext
    {
        public DbSet<Service> Services { get; set; }    
        public DbSet<ServiceType> ServiceTypes { get; set; }    
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL(BaseConnection.Connection, OnConfiguringMySQL);
        }

        private void OnConfiguringMySQL(MySQLDbContextOptionsBuilder builder)
        {
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<ServiceType>().ConfigureServiceType();
        //    modelBuilder.Entity<Service>().ConfigureService();
        //    //modelBuilder.Entity<UseServiceDetail>().ConfigureUseServiceDetail(includeStaffRelationship: false, includeInvoiceRelationship: false);
        //}
    }
    public class ServiceTypeEFCoreDAO : DbContext
    {
        public DbSet<Service> Services { get; set; }
        public DbSet<ServiceType> ServiceTypes { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL(BaseConnection.Connection, OnConfiguringMySQL);
        }

        private void OnConfiguringMySQL(MySQLDbContextOptionsBuilder builder)
        {
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<ServiceType>().ConfigureServiceType();
        //    modelBuilder.Entity<Service>().ConfigureService();
        //}
    }
    public class RoleEFCoreDAO : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL(BaseConnection.Connection, OnConfiguringMySQL);
        }

        private void OnConfiguringMySQL(MySQLDbContextOptionsBuilder builder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>().ConfigureRole();
            modelBuilder.Entity<Staff>().ConfigureStaff();
        }
    }
    public class StaffEFCoreDAO : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL(BaseConnection.Connection, OnConfiguringMySQL);
        }

        private void OnConfiguringMySQL(MySQLDbContextOptionsBuilder builder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>().ConfigureRole();
            modelBuilder.Entity<Account>().ConfigureAccount();
            modelBuilder.Entity<PermissionGroup>().ConfigurePermissionGroup();
            modelBuilder.Entity<Staff>().ConfigureStaff();
        }
    }
}
