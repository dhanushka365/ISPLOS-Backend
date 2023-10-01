using Core.Entities;
using Core.Entities.Identity;
using Core.Entities.OrderAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IOrderRepository :IGenericRepository<Order>
    {

        Task<List<Order>> GetAll();

        Task<Order> FindById(Expression<Func<Order, bool>> expression);

        Task<List<Order>> GetAllByParams(Expression<Func<Order, bool>> expression);

        Task<List<ProductInfo>> GetALLByProductAndCount();

        
    }
}
