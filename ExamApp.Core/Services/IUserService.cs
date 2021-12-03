using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExamApp.Core.Models;

namespace ExamApp.Core.Services
{
    public interface IUserService
    {
        IEnumerable<User> GetAll();
        User Get(int id);
        User Create(User model);
        void Update(User modelToBeUpdated, User model);
        void Delete(int id);
        User Authorize(User user);
    }
}