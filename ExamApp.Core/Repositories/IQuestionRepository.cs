using ExamApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ExamApp.Core.Repositories
{
    public interface IQuestionRepository : IRepository<Question>
    {
        Task<IEnumerable<Question>> GetAllAsync();
        Task<Question> GetAsync(int id);
        void Remove(Question model);
    }
}
