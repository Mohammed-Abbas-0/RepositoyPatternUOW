using RepositoryPatternWithUOW.Core.IRepository;
using RepositoryPatternWithUOW.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPatternWithUOW.Core.IUnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
          IGenericRepository<Author> genericAuthorRepository { get; }
          IGenericRepository<Book> genericBookRepository { get; }

        int CountOfRowsEffected();
    }
}
