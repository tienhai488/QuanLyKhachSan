namespace HotelManagement.Data.Access
{
    using HotelManagement.Data.Access.Core;

    using Microsoft.EntityFrameworkCore;

    using System;
    using System.Numerics;

    public class AccountDAO : DbContext
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
}
