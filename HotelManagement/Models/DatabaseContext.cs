using HotelManagement.DTO;
using HotelManagement.GUI;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Models
{
    public class DatabaseContext : DbContext
    {
        private string connectionString = @"
                server=localhost;
                user=root;
                password=;database=qlks";

        private MySqlServerVersion version = new(new Version(8, 0));

        //public DbSet<Product> Products { get; set; }
        public DbSet<ServiceType> ServiceTypes { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(connectionString, version);

        }
    }
}
