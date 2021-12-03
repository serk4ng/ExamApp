using ExamApp.Core;
using ExamApp.Core.Models;
using ExamApp.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamApp.Services
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork _unitOfWork;
        public UserService(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        public User Create(User model)
        {
             _unitOfWork.Users.AddAsync(model);
             _unitOfWork.CommitAsync();
            return model;
        }

        public void Delete(int id)
        {
            var model = this.Get(id);
            _unitOfWork.Users.Remove(model);
             _unitOfWork.CommitAsync();
        }

       public IEnumerable<User> GetAll()
        {
           var list = _unitOfWork.Users.GetAllAsync().Result;

            return list;
        }

        public User Get(int id)
        {
            var model = _unitOfWork.Users
                .GetAsync(id).Result;
            return model;
        }
 

        public void Update(User o, User n)
        {
            o.Username = n.Username;
            o.Password = n.Password;

             _unitOfWork.CommitAsync();
        }

        public User Authorize(User user)
        {
            var model = _unitOfWork.Users.GetAllAsync().Result.Where(x=>x.Username == user.Username).FirstOrDefault();

            if (model == null)
            {
                return null;
            }

            if (model.Username == user.Username && model.Password == user.Password)
            {
                return model;
            }
            else
            {
                return null;
            }
        }
    }
}
