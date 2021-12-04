using ExamApp.Core.Services;
using ExamApp.UI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ExamApp.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IExamService _examService;
        private readonly IQuestionOptionService _questionOptionService;
        private readonly IQuestionService _questionService;

        public HomeController(IExamService examService, IQuestionService questionService, IQuestionOptionService questionOptionService)
        {
            this._examService = examService;
            this._questionOptionService = questionOptionService;
            this._questionService = questionService;
        }

        public IActionResult Index()
        {
            var exams = _examService.GetAll();
            return View(exams);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
