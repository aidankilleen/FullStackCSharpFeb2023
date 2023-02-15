using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstSqlServer.Models
{
    public class Member
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Email { get; set; } = null!;
        public bool Active { get; set; }

        public string? Description { get; set; }

        public override string? ToString()
        {
            return $"{ Name } - { Email} - { (Active ? "Active" : "Inactive") }";
        }
    }
}
