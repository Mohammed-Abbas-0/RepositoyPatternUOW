using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPatternWithUOW.Core.IRepository
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> FetchDetailsById(int Id);
        T Find(Expression<Func<T,bool>> match);
        T Find(Expression<Func<T,bool>> match,string[] includeItems = null);
        Task<IEnumerable<T>> FindAllData(Expression<Func<T,bool>> match, string[] includeItems = null, int skip = 0, int take = 0);
    }
}
