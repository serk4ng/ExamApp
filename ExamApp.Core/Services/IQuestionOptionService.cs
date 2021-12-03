using ExamApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExamApp.Core.Services
{
    public interface IQuestionOptionService
    {
        IEnumerable<QuestionOption> GetAll();
        QuestionOption Get(int id);
        QuestionOption Create(QuestionOption model);
        void Update(QuestionOption modelToBeUpdated, QuestionOption model);
        void Delete(int id);
    }
}
