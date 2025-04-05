using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPatternWithUOW.Core.Consts
{
    public class OrderBy
    {
        private string Ascending;
        private string Descending;

        // Accessor
        public string GetOrderAsc()
        {
            return this.Ascending = "Asc";
        }
        public string GetOrderDesc()
        {
            return this.Descending = "Desc";
        }
    }
}
