using ExamApp.Core;
using ExamApp.Core.Models;
using ExamApp.Core.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExamApp.Services
{
    public class QuestionService : IQuestionService
    {
        private readonly IUnitOfWork _unitOfWork;
        public QuestionService(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        public Question Create(Question model)
        {
            model.Status = true;
            model.CreationDate = DateTime.Now;
            _unitOfWork.Questions.AddAsync(model);
            _unitOfWork.CommitAsync();
            return model;
        }

        public void Delete(int id)
        {
            var model = this.Get(id);
            _unitOfWork.Questions.Remove(model);
            _unitOfWork.CommitAsync();
        }

        public IEnumerable<Question> GetAll()
        {
            var list = _unitOfWork.Questions.GetAllAsync().Result;

            return list;
        }

        public Question Get(int id)
        {
            var model = _unitOfWork.Questions
                .GetAsync(id).Result;
            return model;
        }


        public void Update(Question o, Question n)
        {
            o.Title = n.Title;
            o.UpdateDate = DateTime.Now;
            _unitOfWork.CommitAsync();
        }
 
    }
}
