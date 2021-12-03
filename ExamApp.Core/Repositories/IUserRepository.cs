using ExamApp.Core.Models;
using ExamApp.Core.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExamApp.Core.Repositories
{
    public interface IUserRepository : IRepository<User>
    {
        Task<IEnumerable<User>> GetAllAsync();
        Task<User> GetAsync(int id);
        void Remove(User model);
    }
}