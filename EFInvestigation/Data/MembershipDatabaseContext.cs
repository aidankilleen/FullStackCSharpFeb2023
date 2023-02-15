using EFInvestigation.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFInvestigation.Data
{
    public class MembershipDatabaseContext : DbContext
    {

        public DbSet<Member> Members { get; set; } = null!;

        public DbSet<Order> Orders { get; set; } = null!;

        public DbSet<OrderDetail> OrderDetails { get; set; } = null!;

        public DbSet<Product> Products { get; set; } = null!;


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source = C:\data\fullstackcsharp\MembershipDb3.db");
        }
    }
}
