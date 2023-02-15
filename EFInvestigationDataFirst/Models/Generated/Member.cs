using System;
using System.Collections.Generic;

namespace EFInvestigationDataFirst.Models
{
    public partial class Member
    {
        public Member()
        {
            Orders = new HashSet<Order>();
        }

        public long Id { get; set; }
        public string Name { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string? Telephone { get; set; }
        public string? PostalAddress { get; set; }
        public long Active { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
