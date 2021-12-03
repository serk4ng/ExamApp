using ExamApp.Core;
using ExamApp.Core.Models;
using ExamApp.Core.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExamApp.Services
{
    public class QuestionOptionService : IQuestionOptionService
    {
        private readonly IUnitOfWork _unitOfWork;
        public QuestionOptionService(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        public QuestionOption Create(QuestionOption model)
        {
            model.Status = true;
            model.CreationDate = DateTime.Now;
            _unitOfWork.QuestionOptions.AddAsync(model);
            _unitOfWork.CommitAsync();
            return model;
        }

        public void Delete(int id)
        {
            var model = this.Get(id);
            _unitOfWork.QuestionOptions.Remove(model);
            _unitOfWork.CommitAsync();
        }

        public IEnumerable<QuestionOption> GetAll()
        {
            var list = _unitOfWork.QuestionOptions.GetAllAsync().Result;

            return list;
        }

        public QuestionOption Get(int id)
        {
            var model = _unitOfWork.QuestionOptions
                .GetAsync(id).Result;
            return model;
        }


        public void Update(QuestionOption o, QuestionOption n)
        {
            o.Title = n.Title;
            o.UpdateDate = DateTime.Now;
            _unitOfWork.CommitAsync();
        }

    }
}
