using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPatternWithUOW.Core.IRepository
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> FetchDetailsById(int Id);
    }
}
