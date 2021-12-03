using ExamApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ExamApp.Core.Repositories
{
    public interface IQuestionOptionRepository : IRepository<QuestionOption>
    {
        Task<IEnumerable<QuestionOption>> GetAllAsync();
        Task<QuestionOption> GetAsync(int id);
        void Remove(QuestionOption model);
    }
}
