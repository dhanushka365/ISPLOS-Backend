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

        Task DeleteByIdAsync(int id);

        //Task<T> GetEntityWithSpec(ISpecification<T> spec);
        //Task<IReadOnlyList<T>> ListAsync(ISpecification<T> spec);
        //Task<int> CountAsync(ISpecification<T> spec);
      
        Task AddAsync(T entity);
      
        void Update(T entity);
        void Delete(T entity);
    }
}
