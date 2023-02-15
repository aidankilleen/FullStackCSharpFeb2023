using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlServerDataFirstInvestigation.Models
{
    public partial class Member
    {
        public override string? ToString()
        {
            return $"{Name} - {Email} - {(Active ? "Active" : "Inactive")} ";
        }
    }
}
