using ExamApp.Core.Models;
using ExamApp.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;

namespace ExamApp.UI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class LoginController : Controller
    {
        private readonly IUserService _userService;
        //protected IUserService _userService => HttpContext.RequestServices.GetService<IUserService>();
        //private readonly IUserService _userService;
        //private readonly IUnitOfWork _unitOfWork;
        //private readonly IHttpContextAccessor _httpContextAccessor;
        //public LoginController(IUserService userService, IUnitOfWork unitOfWork, IHttpContextAccessor  httpContextAccessor)
        //{
        //    _httpContextAccessor = httpContextAccessor;
        //    _unitOfWork = unitOfWork;
        //    _userService = userService;

        //}

        public LoginController(IUserService userService)
        {
            this._userService = userService;
        }
        public IActionResult Index()
        {
            var user = _userService.GetAll();
            return View(user);
        }


        [HttpPost]
        public IActionResult Login(User user)
        {
            var auth = _userService.Authorize(user);
            if (auth == null)
            {
                return RedirectToAction("Index", "Login");
            }
            else
            {
                HttpContext.Session.SetString("user", JsonConvert.SerializeObject(user));
                return RedirectToAction("Index", "Admin");
            }

        }

        public IActionResult Logout()
        {
            HttpContext.Session.Remove("user");
            return RedirectToAction("Index", "Login");
        }
    }
}
