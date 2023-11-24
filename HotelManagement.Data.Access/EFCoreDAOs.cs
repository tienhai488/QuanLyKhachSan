namespace HotelManagement.Data.Access
{
    using HotelManagement.Data.Access.Core;

    using Microsoft.EntityFrameworkCore;

    using MySql.EntityFrameworkCore.Infrastructure;

    using System;
    using System.Numerics;

    public class CustomerEFCoreDAO : DbContext
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
    public class ReservationEFCoreDAO : DbContext
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
        //    modelBuilder.Entity<Reservation>().ConfigureReservation();
        //}
    }
    public class RentRoomDetailEFCoreDAO : DbContext
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
    public class UseServiceDetailEFCoreDAO : DbContext
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
    public class InvoiceEFCoreDAO : DbContext
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
    public class AccountEFCoreDAO : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseMySQL(BaseConnection.Connection);

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

        public Account? SignIn(string userName, string password)
            => (from a in Set<Account>()
                where a.UserName == userName
                && a.Password == password
                select a).FirstOrDefault();
    }
    public class PermissionGroupEFCoreDAO : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseMySQL(BaseConnection.Connection);

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PermissionGroup>().ConfigurePermissionGroup();
        }

        public IEnumerable<PermissionGroup> PermissionGroups => Set<PermissionGroup>();

        public BigInteger UsableId
        {
            get
            {
                IEnumerable<PermissionGroup> groups = PermissionGroups.ToList();
                return (from a in groups
                        let ids = from b in groups
                                   join c in groups
                                   on b.Id + 1 equals c.Id
                                   select b.Id
                        where !ids.Contains(a.Id)
                        select a.Id).FirstOrDefault(0) + 1;
            }
        }
    }
    public class RoomEFCoreDAO : DbContext
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
    public class ConvenienceEFCoreDAO : DbContext
    {
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseMySQL(BaseConnection.Connection);

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Convinience>().ConfigureConvenience();
        //    modelBuilder.Entity<RoomType>().ConfigureRoomType();
        //}
    }
    public class RoomTypeEFCoreDAO : DbContext
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


    public class CancelationStatusEFCoreDAO : UseServiceDetail { }
    public class ServiceEFCoreDAO : DbContext
    {
        public DbSet<Service> Services { get; set; }    
        public DbSet<ServiceType> ServiceTypes { get; set; }    
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseMySQL(BaseConnection.Connection);

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
            => optionsBuilder.UseMySQL(BaseConnection.Connection);

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<ServiceType>().ConfigureServiceType();
        //    modelBuilder.Entity<Service>().ConfigureService();
        //}
    }
    public class RoleEFCoreDAO : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseMySQL(BaseConnection.Connection);

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>().ConfigureRole();
        }

        public IEnumerable<Role> Roles => Set<Role>();

        public BigInteger UsableId
        {
            get
            {
                IEnumerable<Role> groups = Roles.ToList();
                return (from a in groups
                        let ids = from b in groups
                                   join c in groups
                                   on b.Id + 1 equals c.Id
                                   select b.Id
                        where !ids.Contains(a.Id)
                        select a.Id).FirstOrDefault(0) + 1;
            }
        }
    }
    public class StaffEFCoreDAO : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseMySQL(BaseConnection.Connection);

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>().ConfigureRole();
            modelBuilder.Entity<Account>().ConfigureAccount();
            modelBuilder.Entity<PermissionGroup>().ConfigurePermissionGroup();
            modelBuilder.Entity<Staff>().ConfigureStaff();
        }

        public Staff? GetStaffWithAccountId(BigInteger uid)
            => (from s in Set<Staff>()
                where s.AccountId == uid
                select s).FirstOrDefault();

        public bool HasStaffWithPermissionGroup(BigInteger id)
            => (from s in Set<Staff>()
                where s.GroupId == id
                select s).Any();

        public bool HasStaffWithRole(BigInteger id)
            => (from s in Set<Staff>()
                where s.RoleId == id
                select s).Any();
    }
}
