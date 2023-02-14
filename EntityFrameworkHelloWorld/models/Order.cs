using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkHelloWorld.models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderPlaced { get; set; }

        public int MemberId { get; set; }
        public Member Member { get; set; } = null!;

        public ICollection<OrderDetail> OrderDetails { get; set; } = null!;
    }
}
