using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVCWebAppInvestigation.Data;
using MVCWebAppInvestigation.Models;

namespace MVCWebAppInvestigation.Controllers
{
    public class UsersController : Controller
    {
        MembershipDbContext _dbContext;

        public UsersController(MembershipDbContext dbContext) {
            _dbContext = dbContext;
        }


        public IActionResult Index()
        {
            ViewData["members"] = _dbContext.Members.ToList<Member>();

            ViewData["title"] = "The User List Page";
            return View();
        }

        public IActionResult About()
        {
            ViewData["title"] = "About User List";
            return View();
        }
    }
}
