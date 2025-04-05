using RepositoryPatternWithUOW.Core.IRepository;
using RepositoryPatternWithUOW.Core.IUnitOfWork;
using RepositoryPatternWithUOW.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPatternWithUOW.EF.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _appDbContext;
        public UnitOfWork(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IGenericRepository<Author> genericAuthorRepository { get; private set; }

        public IGenericRepository<Book> genericBookRepository { get; private set; }

        public int CountOfRowsEffected()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
        }
    }
}
