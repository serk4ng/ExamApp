using Microsoft.AspNetCore.Mvc;

namespace ExamApp.UI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
