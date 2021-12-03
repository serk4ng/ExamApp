using ExamApp.Core;
using ExamApp.Core.Repositories;
using ExamApp.Data.Repositories;
using System.Threading.Tasks;
 
namespace ExamApp.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationContext _context;
        private UserRepository _userRepository;
        private ExamRepository _examRepository;
        private QuestionRepository _questionRepository;
        public QuestionOptionRepository _questionOptionRepository;

        public UnitOfWork(ApplicationContext context)
        {
            this._context = context;
        }

        public IUserRepository Users => _userRepository ??= new UserRepository(_context);
        public IExamRepository Exams => _examRepository ??= new ExamRepository(_context);
        public IQuestionRepository Questions => _questionRepository ??= new QuestionRepository(_context);
        public IQuestionOptionRepository QuestionOptions => _questionOptionRepository ??= new QuestionOptionRepository(_context);
        public async Task<int> CommitAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}