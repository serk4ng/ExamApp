using ExamApp.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace ExamApp.UI.Controllers
{
    public class ExamController : Controller
    {
        private readonly IExamService _examService;
        private readonly IQuestionOptionService _questionOptionService;
        private readonly IQuestionService _questionService;

        public ExamController(IExamService examService, IQuestionService questionService, IQuestionOptionService questionOptionService)
        {
            this._examService = examService;
            this._questionOptionService = questionOptionService;
            this._questionService = questionService;
        }
        public IActionResult Index(int id)
        {
            var exam = _examService.Get(id);
            return View(exam);
        }
    }
}
