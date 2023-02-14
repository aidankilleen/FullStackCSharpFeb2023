using EntityFrameworkHelloWorld.models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace EntityFrameworkHelloWorld.data
{
    public class MembershipDatabaseContext : DbContext
    {

        public DbSet<Member> Members { get; set; } = null!;

        public DbSet<Product> Products { get; set; } = null!;

        public DbSet<AccessLog> AccessLogs { get; set; } = null!;

        public DbSet<Order> Orders { get; set; } = null!;




        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlite(@"Data Source = C:\data\fullstackcsharp\Membership.db");

            /*
            optionsBuilder.UseSqlServer(@"Server = tcp:professionaltraining.database.windows.net, 1433;
                                        Initial Catalog = trainingdb; Persist Security Info = False; 
                                        User ID=ptdbuser; Password=; 
                                        MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; 
                                        Connection Timeout = 30;");
            */

        }
    }
}
