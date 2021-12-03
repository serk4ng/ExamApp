using Microsoft.AspNetCore.Mvc;

namespace ExamApp.UI.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
