using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

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
            return View();
        }
    }
}
