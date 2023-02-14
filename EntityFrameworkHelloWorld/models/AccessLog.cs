using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkHelloWorld.models
{
    public class AccessLog
    {
        public int Id { get; set; }

        public int MemberId { get; set; }

        public Member Member { get; set; } = null!;

        public DateOnly Date { get; set; }

    }
}
