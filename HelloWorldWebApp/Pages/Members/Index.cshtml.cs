using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using HelloWorldWebApp.Data;
using HelloWorldWebApp.Models;

namespace HelloWorldWebApp
{
    public class IndexModel : PageModel
    {
        private readonly HelloWorldWebApp.Data.MembershipDbContext _context;

        public IndexModel(HelloWorldWebApp.Data.MembershipDbContext context)
        {
            _context = context;
        }

        public IList<Member> Member { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Members != null)
            {
                Member = await _context.Members.ToListAsync();
            }
        }
    }
}
