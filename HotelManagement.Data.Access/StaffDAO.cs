namespace HotelManagement.Data.Access
{
    using HotelManagement.Data.Access.Core;

    using Microsoft.EntityFrameworkCore;

    using MySql.EntityFrameworkCore.Infrastructure;

    using System.Numerics;
    public class StaffDAO : DbContext
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

        public IEnumerable<Role> Roles => Set<Role>();

        public IEnumerable<Account> Accounts => Set<Account>();

        public IEnumerable<PermissionGroup> Groups => Set<PermissionGroup>();

        public IEnumerable<Staff> Staffs => Set<Staff>();

        public BigInteger UsableId
        {
            get
            {
                var query = from a in Staffs select a.Id;
                return query.Any() ? query.Max() + 1 : 1;
            }
        }

        public Staff? GetStaffWithAccountId(BigInteger uid)
            => (from s in Set<Staff>().Include(nameof(Staff.Account))
                .Include(nameof(Staff.Group)).Include(nameof(Staff.Role))
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
