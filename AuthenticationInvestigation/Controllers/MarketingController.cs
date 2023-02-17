using Microsoft.AspNetCore.Mvc;

namespace AuthenticationInvestigation.Controllers
{
    public class MarketingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult PromoA()
        {
            return View();
        }

        public IActionResult PromoB()
        {
            return View();
        }
    }
}
