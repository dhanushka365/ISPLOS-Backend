using Core.Entities.Identity;
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
    public class OrderRepository : GenericRepository<Order>, IOrderRepository
    {
        private readonly StoreContext context;

        public OrderRepository(StoreContext context) : base(context)
        {
            this.context = context;
        }

        public async Task<Order> FindById(Expression<Func<Order, bool>> expression)
        {
            return await context.Orders.Include(x => x.User).Include(x => x.OrderProducts).ThenInclude(x => x.Product).Where(expression).FirstOrDefaultAsync();
        }

        public async Task<List<Order>> GetAll()
        {
          return await context.Orders.Include(x => x.User).Include(x => x.OrderProducts).ThenInclude(x => x.Product).ToListAsync();
        }
    }
}
