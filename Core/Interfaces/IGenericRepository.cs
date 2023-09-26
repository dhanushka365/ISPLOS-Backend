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

        Task<IReadOnlyList<T>> ListAllAsync();

        IQueryable<T> GetAllQueryable();

        Task AddAsync(T entity);

        Task SaveAsync();

        void Update(T entity);

        void Delete(T entity);
    }
}
