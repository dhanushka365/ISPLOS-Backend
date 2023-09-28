using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> GetByIdAsync(Expression<Func<T, bool>> predicate);

        Task<T> FilterObject(Expression<Func<T, bool>> predicate);

        Task<List<T>> FilterList(Expression<Func<T, bool>> predicate);

        Task<List<T>> ListAllAsync();
      
        Task<IReadOnlyList<T>> ListAllAsync(
            Expression<Func<T, bool>> filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            int? pageNumber = null,
            int? pageSize = null);

        IQueryable<T> GetAllQueryable();

        IQueryable<T> Query();
        Task AddAsync(T entity);

        Task UpdateAsync(T entity);


        Task SaveAsync();

        void Update(T entity);

        void Delete(T entity);

    }
}
