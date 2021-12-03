using ExamApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExamApp.Core.Services
{
    public interface IExamService
    {
        IEnumerable<Exam> GetAll();
        Exam Get(int id);
        Exam Create(Exam model);
        void Update(Exam modelToBeUpdated, Exam model);
        void Delete(int id);
    }
}
