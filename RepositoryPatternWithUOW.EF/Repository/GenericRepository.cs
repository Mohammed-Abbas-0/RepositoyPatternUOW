using Microsoft.EntityFrameworkCore;
using RepositoryPatternWithUOW.Core.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPatternWithUOW.EF.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class 
    {
        private readonly AppDbContext _db;
        public GenericRepository(AppDbContext db) => _db = db;

        public async Task<T> FetchDetailsById(int Id) => await _db.Set<T>().FindAsync(Id);

        #region Over ride (Find Function)
        public T Find(Expression<Func<T, bool>> match, string[] includeItems = null)
        {
            IQueryable<T> query = _db.Set<T>();
            if (includeItems != null)
                foreach (string item in includeItems) query.Include(item);
            return query.FirstOrDefault(match);
        }

        public T Find(Expression<Func<T, bool>> match)
        {
            IQueryable<T> query = _db.Set<T>();
            return query.FirstOrDefault(match);
        }

        #endregion
        public async Task<IEnumerable<T>> FindAllData(Expression<Func<T, bool>> match, string[] includeItems = null,int skip = 0,int take=0)
        {
            IQueryable<T> query = _db.Set<T>();
            if (includeItems != null)
                foreach (string item in includeItems) query.Include(item);
            if( skip == 0 || take == 0 )
                return await query.Where(match).ToListAsync();
            return await query.Where(match).Skip(skip).Take(take).ToListAsync();
        }
    }
}
