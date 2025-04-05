using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPatternWithUOW.Core.IRepository
{
   public interface IVehicleGeneric<T>  where T : class
    {
        public Task<T> GetDetails(int Id);
        //public Task<string> GetDetailsWithOwnerName(int Id);
        public Task<T> Delete(int Id);
    }
}
