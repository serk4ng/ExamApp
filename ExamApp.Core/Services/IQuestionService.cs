using ExamApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExamApp.Core.Services
{
    public interface IQuestionService
    {
        IEnumerable<Question> GetAll();
        Question Get(int id);
        Question Create(Question model);
        void Update(Question modelToBeUpdated, Question model);
        void Delete(int id);
    }
}
