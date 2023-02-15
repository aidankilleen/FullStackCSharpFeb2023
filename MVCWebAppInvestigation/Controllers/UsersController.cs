using Microsoft.AspNetCore.Mvc;

namespace MVCWebAppInvestigation.Controllers
{
    public class UsersController : Controller
    {
        public IActionResult Index()
        {
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
