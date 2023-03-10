using System;
using System.Collections.Generic;

namespace MVCWebAppInvestigation.Models
{
    public partial class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Category { get; set; }
        public string? Description { get; set; }
        public string? Filename { get; set; }
    }
}
