using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkHelloWorld.models
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        [Column(TypeName ="REAL")]
        public decimal Price { get; set; }

    }
}
