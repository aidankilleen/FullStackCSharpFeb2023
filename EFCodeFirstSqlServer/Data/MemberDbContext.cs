using EFCodeFirstSqlServer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstSqlServer.Data
{
    public class MemberDbContext : DbContext
    {
        public MemberDbContext()
        {
            
        }
        public MemberDbContext(DbContextOptions<MemberDbContext> options)
            : base(options)
        {
        }


        public DbSet<Member> Members { get; set; } = null!;

        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=MembershipDb;Trusted_Connection=True;MultipleActiveResultSets=true");

            //optionsBuilder.UseSqlServer("Name=DefaultConnection");
        }
        

        

    }
}
