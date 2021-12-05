using ExamApp.Core.Models;
using ExamApp.Core.Services;
using ExamApp.UI.Dto;
using Fizzler.Systems.HtmlAgilityPack;
using HtmlAgilityPack;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace ExamApp.UI.Areas.Admin.Controllers
{
    public class ExamController : BaseController
    {
        private readonly IExamService _examService;
        private readonly IQuestionOptionService _questionOptionService;
        private readonly IQuestionService _questionService;

        public ExamController(IExamService  examService, IQuestionService questionService, IQuestionOptionService questionOptionService)
        {
            this._examService = examService;
            this._questionOptionService = questionOptionService;
            this._questionService = questionService;
        }

        public IActionResult List()
        {
            var result = _examService.GetAll();
            return View(result);
        }
        public IActionResult Create(int? id)
        {
            if (id == null)
            {//get the page
                var web = new HtmlWeb();
                var document = web.Load("https://www.wired.com/");
                var page = document.DocumentNode;
                List<string> titles = new List<string>();
                List<string> descriptions = new List<string>();
                //loop through all div tags with item css class
                foreach (var item in page.QuerySelectorAll(".SummaryCollageEightGridItemList-drfwxm .summary-item__hed"))
                {
                    titles.Add(item.InnerText);
                    //descriptions.Add(item.QuerySelector("h3:not(.share)").InnerText);
                }
                foreach (var item in page.QuerySelectorAll(".SummaryCollageEightGridItemList-drfwxm .summary-item__hed-link"))
                {
                    var url = "https://www.wired.com/" + item.GetAttributeValue("href","");
                    
                    var subdocument = web.Load(url);
                    var subpage = subdocument.DocumentNode;

                    string a="";
                    foreach (var item2 in subpage.QuerySelectorAll(".BodyWrapper-ctnerm p"))
                    {
                        a += item2.InnerText + "<br/><br/>";
                    }

                    descriptions.Add(a);
                }

                ViewBag.titles = titles;
                ViewBag.descriptions = descriptions;
                return View();

               
            }
            else
            {
                var result = _examService.Get((int)id);
                return View(result);
            }
          
        }

        [HttpPost]
        public IActionResult Create(ExamCreateViewModel viewModel)
        {
            Exam exam = new Exam();
            exam.Title = viewModel.ExamTitle;
            exam.Description = viewModel.ExamDescription;

            _examService.Create(exam);

            Question q1 = new Question();
            q1.Title = viewModel.QuestionTitle1;
            q1.ExamId = exam.Id;

            Question q2 = new Question();
            q2.Title = viewModel.QuestionTitle2;
            q2.ExamId = exam.Id;

            Question q3 = new Question();
            q3.Title = viewModel.QuestionTitle3;
            q3.ExamId = exam.Id;

            Question q4 = new Question();
            q4.Title = viewModel.QuestionTitle4;
            q4.ExamId = exam.Id;


            _questionService.Create(q1);
            _questionService.Create(q2);
            _questionService.Create(q3);
            _questionService.Create(q4);


            /* question1 options */

           QuestionOption q1a = new QuestionOption();

            q1a.QuestionId = q1.Id;
            q1a.Title = viewModel.QuestionOption1A;
            q1a.Option = "A";
            q1a.IsCorrect = viewModel.Question1Answer == 1 ? true : false;

            QuestionOption q1b = new QuestionOption();

            q1b.QuestionId = q1.Id;
            q1b.Title = viewModel.QuestionOption1B;
            q1b.Option = "B";
            q1b.IsCorrect = viewModel.Question1Answer == 2 ? true : false;

            QuestionOption q1c = new QuestionOption();

            q1c.QuestionId = q1.Id;
            q1c.Title = viewModel.QuestionOption1C;
            q1c.Option = "C";
            q1c.IsCorrect = viewModel.Question1Answer == 3 ? true : false;

            QuestionOption q1d = new QuestionOption();

            q1d.QuestionId = q1.Id;
            q1d.Title = viewModel.QuestionOption1D;
            q1d.Option = "D";
            q1d.IsCorrect = viewModel.Question1Answer == 4 ? true : false;

            _questionOptionService.Create(q1a);
            _questionOptionService.Create(q1b);
            _questionOptionService.Create(q1c);
            _questionOptionService.Create(q1d);

            /* question2 options */
            QuestionOption q2a = new QuestionOption();

            q2a.QuestionId = q2.Id;
            q2a.Title = viewModel.QuestionOption2A;
            q2a.Option = "A";
            q2a.IsCorrect = viewModel.Question2Answer == 1 ? true : false;

            QuestionOption q2b = new QuestionOption();

            q2b.QuestionId = q2.Id;
            q2b.Title = viewModel.QuestionOption2B;
            q2b.Option = "B";
            q2b.IsCorrect = viewModel.Question2Answer == 2 ? true : false;

            QuestionOption q2c = new QuestionOption();

            q2c.QuestionId = q2.Id;
            q2c.Title = viewModel.QuestionOption2C;
            q2c.Option = "C";
            q2c.IsCorrect = viewModel.Question2Answer == 3 ? true : false;

            QuestionOption q2d = new QuestionOption();

            q2d.QuestionId = q2.Id;
            q2d.Title = viewModel.QuestionOption2D;
            q2d.Option = "D";
            q2d.IsCorrect = viewModel.Question2Answer == 4 ? true : false;

            _questionOptionService.Create(q2a);
            _questionOptionService.Create(q2b);
            _questionOptionService.Create(q2c);
            _questionOptionService.Create(q2d);


            /* question3 options */
            QuestionOption q3a = new QuestionOption();

            q3a.QuestionId = q3.Id;
            q3a.Title = viewModel.QuestionOption3A;
            q3a.Option = "A";
            q3a.IsCorrect = viewModel.Question3Answer == 1 ? true : false;

            QuestionOption q3b = new QuestionOption();

            q3b.QuestionId = q3.Id;
            q3b.Title = viewModel.QuestionOption3B;
            q3b.Option = "B";
            q3b.IsCorrect = viewModel.Question3Answer == 2 ? true : false;

            QuestionOption q3c = new QuestionOption();

            q3c.QuestionId = q3.Id;
            q3c.Title = viewModel.QuestionOption3C;
            q3c.Option = "C";
            q3c.IsCorrect = viewModel.Question3Answer == 3 ? true : false;

            QuestionOption q3d = new QuestionOption();

            q3d.QuestionId = q3.Id;
            q3d.Title = viewModel.QuestionOption3D;
            q3d.Option = "D";
            q3d.IsCorrect = viewModel.Question3Answer == 4 ? true : false;

            _questionOptionService.Create(q3a);
            _questionOptionService.Create(q3b);
            _questionOptionService.Create(q3c);
            _questionOptionService.Create(q3d);


            /* question4 options */
            QuestionOption q4a = new QuestionOption();

            q4a.QuestionId = q4.Id;
            q4a.Title = viewModel.QuestionOption4A;
            q4a.Option = "A";
            q4a.IsCorrect = viewModel.Question4Answer == 1 ? true : false;

            QuestionOption q4b = new QuestionOption();

            q4b.QuestionId = q4.Id;
            q4b.Title = viewModel.QuestionOption4B;
            q4b.Option = "B";
            q4b.IsCorrect = viewModel.Question4Answer == 2 ? true : false;

            QuestionOption q4c = new QuestionOption();

            q4c.QuestionId = q4.Id;
            q4c.Title = viewModel.QuestionOption4C;
            q4c.Option = "C";
            q4c.IsCorrect = viewModel.Question4Answer == 3 ? true : false;

            QuestionOption q4d = new QuestionOption();

            q4d.QuestionId = q4.Id;
            q4d.Title = viewModel.QuestionOption4D;
            q4d.Option = "D";
            q4d.IsCorrect = viewModel.Question4Answer == 4 ? true : false;

            _questionOptionService.Create(q4a);
            _questionOptionService.Create(q4b);
            _questionOptionService.Create(q4c);
            _questionOptionService.Create(q4d);


            return RedirectToAction("List","Exam");
        }
        public IActionResult Delete(int id)
        {
            _examService.Delete(id);
            return RedirectToAction("List");
        }
    }
}
