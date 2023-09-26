using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.Specifications
{
    public class BaseSpecification<T> : ISpecification<T>
    {
        public BaseSpecification()
        {
        }

        public BaseSpecification(Expression<Func<T, bool>> criteria)
        {
            Criteria = criteria;
        }

        public Expression<Func<T, bool>> Criteria { get; }

        public List<Expression<Func<T, object>>> Includes { get; } = new List<Expression<Func<T, object>>>();//this is the include clause

        public Expression<Func<T, object>> OrderBy { get; private set; }//this is the order by clause

        public Expression<Func<T, object>> OrderByDescending { get; private set; }//this is the order by descending clause

        public int Take { get; private set; }//this is the take clause

        public int Skip { get; private set; }//this is the skip clause

        public bool IsPagingEnabled { get; private set; }//this is the paging clause

        protected void AddInclude(Expression<Func<T, object>> includeExpression)//Replace list of Includes in the the Product Repository with this method
        {
            Includes.Add(includeExpression);
        }

        protected void AddOrderBy(Expression<Func<T, object>> orderByExpression)
        {
            OrderBy = orderByExpression;
        }

        protected void AddOrderByDescending(Expression<Func<T, object>> orderByDescExpression)
        {
            OrderByDescending = orderByDescExpression;
        }

        protected void ApplyPaging(int skip, int take)
        {
            Skip = skip;
            Take = take;
            IsPagingEnabled = true;
        }
    }
}
