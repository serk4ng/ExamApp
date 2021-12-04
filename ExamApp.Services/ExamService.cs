using ExamApp.Core;
using ExamApp.Core.Models;
using ExamApp.Core.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace ExamApp.Services
{
    public class ExamService : IExamService
    {
        private readonly IUnitOfWork _unitOfWork;
        public ExamService(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        public Exam Create(Exam model)
        {
            model.Status = true;
            model.CreationDate = DateTime.Now;
            _unitOfWork.Exams.AddAsync(model);
            _unitOfWork.CommitAsync();
            return model;
        }

        public void Delete(int id)
        {
            var model = this.Get(id);
            _unitOfWork.Exams.Remove(model);
            _unitOfWork.CommitAsync();
        }

        public IEnumerable<Exam> GetAll()
        {
            var list = _unitOfWork.Exams.GetAllAsync().Result;

            foreach (var item in list)
            {
                item.Questions = _unitOfWork.Questions.GetAllAsync().Result.Where(x=>x.ExamId == item.Id).ToList();

                foreach (var item2 in item.Questions)
                {
                    item2.QuestionOptions = _unitOfWork.QuestionOptions.GetAllAsync().Result.Where(x=>x.QuestionId == item2.Id).ToList();
                }
            }
            
            return list;
        }

        public Exam Get(int id)
        {
            var model = _unitOfWork.Exams
                .GetAsync(id).Result;
            model.Questions = _unitOfWork.Questions.GetAllAsync().Result.Where(x => x.ExamId == id).ToList();
            foreach (var item in model.Questions)
            {
                item.QuestionOptions = _unitOfWork.QuestionOptions.GetAllAsync().Result.Where(x => x.QuestionId == item.Id).ToList();
            }
            return model;
        }


        public void Update(Exam o, Exam n)
        {
            o.Title = n.Title;
            o.Description = n.Description;
            
            o.UpdateDate = DateTime.Now;
            _unitOfWork.CommitAsync();
        }

    }
}
