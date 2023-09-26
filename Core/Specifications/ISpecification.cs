using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.Specifications
{
    public interface ISpecification<T>
    {
        Expression<Func<T, bool>> Criteria { get; }//this is the where clause
        List<Expression<Func<T, object>>> Includes { get; }//this is the include clause
        Expression<Func<T, object>> OrderBy { get; }//this is the order by clause
        Expression<Func<T, object>> OrderByDescending { get; }//this is the order by descending clause
        int Take { get; }//this is the take clause
        int Skip { get; }//this is the skip clause
        bool IsPagingEnabled { get; }//this is the paging clause
    }
}
