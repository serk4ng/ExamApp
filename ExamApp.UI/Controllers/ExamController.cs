using ExamApp.Core.Models;
using ExamApp.Core.Services;
using ExamApp.UI.Dto;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
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

        public ExamCreateViewModel CheckExam(ExamCheckViewModel viewModel)
        {
            var exam = _examService.Get(viewModel.Id);
            ExamCreateViewModel ec = new ExamCreateViewModel();
            ec.Id = exam.Id;
            ec.Question1Answer = (byte)(exam.Questions[0].QuestionOptions.ToList().IndexOf(exam.Questions[0].QuestionOptions.Where(x => x.IsCorrect == true).FirstOrDefault()) + 1);
            ec.Question2Answer = (byte)(exam.Questions[1].QuestionOptions.ToList().IndexOf(exam.Questions[1].QuestionOptions.Where(x => x.IsCorrect == true).FirstOrDefault()) + 1);
            ec.Question3Answer = (byte)(exam.Questions[2].QuestionOptions.ToList().IndexOf(exam.Questions[2].QuestionOptions.Where(x => x.IsCorrect == true).FirstOrDefault()) + 1);
            ec.Question4Answer = (byte)(exam.Questions[3].QuestionOptions.ToList().IndexOf(exam.Questions[3].QuestionOptions.Where(x => x.IsCorrect == true).FirstOrDefault()) + 1);

            ec.Question1UserAnswer = viewModel.Question1UserAnswer;
            ec.Question2UserAnswer = viewModel.Question2UserAnswer;
            ec.Question3UserAnswer = viewModel.Question3UserAnswer;
            ec.Question4UserAnswer = viewModel.Question4UserAnswer;

            return ec;
        }
    }
}
