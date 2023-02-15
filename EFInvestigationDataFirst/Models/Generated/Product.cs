using System;
using System.Collections.Generic;

namespace EFInvestigationDataFirst.Models
{
    public partial class Product
    {
        public Product()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public long Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public string Price { get; set; } = null!;
        public long? StockLevel { get; set; }
        public string? Category { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
