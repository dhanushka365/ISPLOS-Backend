using Core.Entities;
using Core.Entities.Identity;
using Core.Entities.OrderAggregate;
using Core.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography;
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

        public async Task<List<Order>> GetAllByParams(Expression<Func<Order, bool>> expression)
        {
           return await context.Orders.Include(x => x.OrderProducts).ThenInclude(x => x.Product).Where(expression).ToListAsync();
        }

        public async Task<List<ProductInfo>> GetALLByProductAndCount()
        {
            // return await context.Orders.Include(x => x.User).Include(x=>x.OrderProducts).ThenInclude(x=>x.Product).Where(expression).GroupBy(x=>x.OrderProducts);

           var Today = DateTime.Now.ToShortDateString();
            // var Result = await context.OrderProducts.Include(x => x.Product).Where(x=>x.Order.OrderDate ==Today).Select(x=>new{x.ProductId, x.Product.Name,x.CurrentPrice,x.Quantity}).GroupBy(x => x.Name).OrderBy(x=>x.Count()).ToListAsync();
             var Result = await context.OrderProducts.Include(x => x.Product).Where(x=>x.Order.OrderDate ==Today).GroupBy(x => x.Product.Name)
                .Select(x=>
                new{
                    ProductId = x.Select(p=>p.ProductId).FirstOrDefault(), 
                    ProductName = x.Key,
                    Price  = x.Select(p=>p.CurrentPrice).FirstOrDefault(),
                    TotalQuntity = x.Sum(x=>x.Quantity)} 
                ).OrderBy(x=>x.TotalQuntity).ToListAsync();

            var Results  =  new List<ProductInfo>();
            foreach (var item in Result)
            {
                var prod = new ProductInfo
                {
                    Price = item.Price,
                    ProductIds = item.ProductId,
                    ProductName = item.ProductName,
                    TotalQuantity = item.TotalQuntity
                };
                Results.Add(prod);
                
            }

            return Results;
        }
    }
}
