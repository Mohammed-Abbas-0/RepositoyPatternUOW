using RepositoryPatternWithUOW.Core.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPatternWithUOW.EF.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class 
    {
        private readonly AppDbContext _db;
        public GenericRepository(AppDbContext db) => _db = db;

        public async Task<T> FetchDetailsById(int Id) => await _db.Set<T>().FindAsync(Id);
    }
}
