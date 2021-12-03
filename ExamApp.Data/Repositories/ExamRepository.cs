using ExamApp.Core.Models;
using ExamApp.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ExamApp.Data.Repositories
{
    public class ExamRepository : Repository<Exam>, IExamRepository
    {
        public ExamRepository(ApplicationContext context)
            : base(context)
        { }

#pragma warning disable CS0108 // 'ExamRepository.GetAllAsync()' hides inherited member 'Repository<Exam>.GetAllAsync()'. Use the new keyword if hiding was intended.
        public async Task<IEnumerable<Exam>> GetAllAsync()
#pragma warning restore CS0108 // 'ExamRepository.GetAllAsync()' hides inherited member 'Repository<Exam>.GetAllAsync()'. Use the new keyword if hiding was intended.
        {
            return await ApplicationContext.Exams
                .ToListAsync();
        }

        public async Task<Exam> GetAsync(int id)
        {
            return await ApplicationContext.Exams
                .SingleOrDefaultAsync(m => m.Id == id);
        }


        private ApplicationContext ApplicationContext
        {
            get { return Context as ApplicationContext; }
        }
    }
}
