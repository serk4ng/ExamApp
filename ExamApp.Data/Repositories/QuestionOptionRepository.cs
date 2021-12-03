using ExamApp.Core.Models;
using ExamApp.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ExamApp.Data.Repositories
{
    public class QuestionOptionRepository : Repository<QuestionOption>,IQuestionOptionRepository
    {
        public QuestionOptionRepository(ApplicationContext context)
            : base(context)
        { }

#pragma warning disable CS0108 // 'QuestionOptionRepository.GetAllAsync()' hides inherited member 'Repository<QuestionOption>.GetAllAsync()'. Use the new keyword if hiding was intended.
        public async Task<IEnumerable<QuestionOption>> GetAllAsync()
#pragma warning restore CS0108 // 'QuestionOptionRepository.GetAllAsync()' hides inherited member 'Repository<QuestionOption>.GetAllAsync()'. Use the new keyword if hiding was intended.
        {
            return await ApplicationContext.QuestionOptions
                .ToListAsync();
        }

        public async Task<QuestionOption> GetAsync(int id)
        {
            return await ApplicationContext.QuestionOptions
                .SingleOrDefaultAsync(m => m.Id == id);
        }


        private ApplicationContext ApplicationContext
        {
            get { return Context as ApplicationContext; }
        }
    }
}
