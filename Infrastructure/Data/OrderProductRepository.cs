using Core.Entities.OrderAggregate;
using Core.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class OrderProductRepository : GenericRepository<OrderProduct>, IOrderProductRepository
    {
        private readonly StoreContext context;

        public OrderProductRepository(StoreContext context) : base(context)
        {
            this.context = context;
        }

        public IQueryable<OrderProduct> FindItemsByOrderID(Expression<Func<OrderProduct, bool>> expression)
        {
            return context.OrderProducts.Include("OrderId").Include("ProductId").Where(expression).AsQueryable();
        }

        public IQueryable<OrderProduct> GetAll()
        {
          return context.OrderProducts.Include("Order").Include("Product").AsQueryable();
        }


    }
}
