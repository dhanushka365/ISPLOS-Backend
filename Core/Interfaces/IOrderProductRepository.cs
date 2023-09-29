using Core.Entities.OrderAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IOrderProductRepository : IGenericRepository<OrderProduct>
    {

        IQueryable<OrderProduct> GetAll();

        IQueryable<OrderProduct> FindItemsByOrderID(Expression<Func<OrderProduct,bool>> expression);



    }
}
