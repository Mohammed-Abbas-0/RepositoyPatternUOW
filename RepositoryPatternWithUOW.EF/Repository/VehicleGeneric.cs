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
    public class VehicleGeneric<T> : IVehicleGeneric<T> where T : class
    {
        private readonly AppDbContext db;

        public VehicleGeneric(AppDbContext db)
        {
            this.db = db;

        }
        public Task<T> Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public async Task<T> GetDetails(int Id) =>
            await db.Set<T>().FindAsync(Id);
        
            //await db.Set<T>().FindAsync(Id);
        //public virtual IEnumerable<T> Get(
        //  Expression<Func<T, bool>> filter = null,
        //  Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            
        //  string includeProperties = "")
        //{
        //    IQueryable<T> query = dbSet;
        //    var e = db.Owners;
        //    if (filter != null)
        //    {
        //        query = query.Where(filter);
        //    }

        //    foreach (var includeProperty in includeProperties.Split
        //        (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
        //    {
        //        query = query.Include(includeProperty);
        //    }
            
        //    if (orderBy != null)
        //    {
        //        return orderBy(query).ToList();
        //    }
        //    else
        //    {
        //        return query.ToList();
        //    }
        //}

        //public async Task<string> GetDetailsWithOwnerName(int Id)
        //{
        //    var QueryModel = await(from p in db.Cars.Where(idx => idx.Id == Id)
        //                           join o in db.Owners on p.Id equals o.CarID
        //                           select new
        //                           {
        //                               Id = p.Id,
        //                               OwnerName = o.OwnerName
        //                           }).FirstOrDefaultAsync();
        //    return QueryModel.OwnerName;
        //}

      

        //public async Task<T> GetDetails(int Id, int OwnerId)
        //{ 
        //    var owner = from 
        //}
        //await db.Set<T>().FindAsync(Id);

    }
}
