using ExamApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ExamApp.Core.Repositories
{
    public interface IExamRepository : IRepository<Exam>
    {
        Task<IEnumerable<Exam>> GetAllAsync();
        Task<Exam> GetAsync(int id);
        void Remove(Exam model);
    }
}
