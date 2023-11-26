namespace HotelManagement.Data.Access
{
    using HotelManagement.Data.Access.Core;

    using Microsoft.EntityFrameworkCore;

    using System;
    using System.Numerics;

    public class PermissionGroupDAO : DbContext
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
}
