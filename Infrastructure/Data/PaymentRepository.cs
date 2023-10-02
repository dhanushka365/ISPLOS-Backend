using Core.Entities;
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
    public class PaymentRepository : GenericRepository<Payment>, IPaymentRepository
    {
        private readonly StoreContext context;

        public PaymentRepository(StoreContext context) : base(context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<Payment>> GetAllByUser(Expression<Func<Payment, bool>> expression)
        {
           return await context.Payments.Include("User").Where(expression).ToListAsync();
        }

        public Task<IEnumerable<Payment>> GetAllOrderByDate()
        {
            throw new NotImplementedException();
        }

    }
}
