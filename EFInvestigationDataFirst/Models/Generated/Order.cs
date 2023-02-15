using System;
using System.Collections.Generic;

namespace EFInvestigationDataFirst.Models
{
    public partial class Order
    {
        public Order()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public long Id { get; set; }
        public string OrderPlaced { get; set; } = null!;
        public string Comments { get; set; } = null!;
        public long MemberId { get; set; }

        public virtual Member Member { get; set; } = null!;
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
