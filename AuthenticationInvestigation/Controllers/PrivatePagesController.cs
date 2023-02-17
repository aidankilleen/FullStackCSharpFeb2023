using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Principal;

namespace AuthenticationInvestigation.Controllers
{
    
    public class PrivatePagesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Authorize]
        public IActionResult Info()
        {
            

            ViewData["name"] = this.User.Identity.Name;
            return View();
        }
    }
}
