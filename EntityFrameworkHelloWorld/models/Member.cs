using Microsoft.EntityFrameworkCore.Update.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkHelloWorld.models
{
    public class Member
    {

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Email { get; set; } = null!;
        public bool Active { get; set; }

        public string? Phone { get; set; }
        
        [Column(TypeName ="REAL")]
        public decimal CreditRating { get; set; }

        public override string? ToString()
        {
            return $"{Id} - {Name} - {Email} - {(Active ? "Active" : "Inactive" )} - { CreditRating }";
        }

        public ICollection<AccessLog> AccessLogs { get; set; } = null!;

        public ICollection<Order> Orders { get; set; } = null!;
    }
}
