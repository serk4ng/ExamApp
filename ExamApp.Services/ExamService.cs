using ExamApp.Core;
using ExamApp.Core.Models;
using ExamApp.Core.Services;
using System;
using System.Collections.Generic;
using System.Text;

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

            return list;
        }

        public Exam Get(int id)
        {
            var model = _unitOfWork.Exams
                .GetAsync(id).Result;
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
