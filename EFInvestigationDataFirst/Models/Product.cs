using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFInvestigationDataFirst.Models
{
    public partial class Product
    {
        public override string? ToString()
        {
            return $"{ Name } - { Category } - { Description } - { Price }";
        }
    }
}
