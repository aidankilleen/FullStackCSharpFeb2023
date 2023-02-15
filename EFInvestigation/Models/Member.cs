using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFInvestigation.Models
{
    public class Member
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Email { get; set; } = null!;
        
        public string? Telephone { get; set; }

        [Column("PostalAddress")]
        public string? Address { get; set; }

        public bool Active { get; set; }

        public ICollection<Order> Orders { get; set; } = null!;

        public override string? ToString()
        {
            return $"{Id} = {Name}"; ;
        }
    }
}
