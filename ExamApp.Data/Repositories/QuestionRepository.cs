using ExamApp.Core.Models;
using ExamApp.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ExamApp.Data.Repositories
{
    public class QuestionRepository : Repository<Question>, IQuestionRepository
    {
        public QuestionRepository(ApplicationContext context)
            : base(context)
        { }


        public async Task<IEnumerable<Question>> GetAllAsync()

        {
            return await ApplicationContext.Questions
                .ToListAsync();
        }

        public async Task<Question> GetAsync(int id)
        {
            return await ApplicationContext.Questions
                .SingleOrDefaultAsync(m => m.Id == id); 
        }


        private ApplicationContext ApplicationContext
        {
            get { return Context as ApplicationContext; }
        }
    }
}
