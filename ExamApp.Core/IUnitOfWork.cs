using System;
using System.Threading.Tasks;
using ExamApp.Core.Repositories;
namespace ExamApp.Core
{
    public interface IUnitOfWork : IDisposable
    {
        IUserRepository Users { get; }
        IExamRepository Exams { get; }
        IQuestionRepository Questions { get; }
        IQuestionOptionRepository QuestionOptions { get; }
        Task<int> CommitAsync();
    }
}