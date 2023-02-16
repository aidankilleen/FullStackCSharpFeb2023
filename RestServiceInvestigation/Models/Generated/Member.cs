using System;
using System.Collections.Generic;

namespace RestServiceInvestigation.Models
{
    public partial class Member
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Email { get; set; } = null!;
        public bool Active { get; set; }
        public string? Description { get; set; }
    }
}
