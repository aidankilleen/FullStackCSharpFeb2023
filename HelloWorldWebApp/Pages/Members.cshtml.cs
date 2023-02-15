using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HelloWorldWebApp.Pages
{
    public class MembersModel : PageModel
    {

        public string Language { get; set; }
        public List<SelectListItem> Languages { get; } = new List<SelectListItem>
        {
            new SelectListItem { Value = "C#", Text = "C#" },
            new SelectListItem { Value = "Javascript", Text = "Javascript" },
            new SelectListItem { Value = "Ruby", Text = "Ruby"  },
        };


        public void OnGet()
        {
            ViewData["message"] = "Welcome to the Web App";
        }
    }
}
