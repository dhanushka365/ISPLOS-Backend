using Core.Entities;
using Core.Interfaces;
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
        public PaymentRepository(StoreContext context) : base(context)
        {
        }

        public Task<IEnumerable<Payment>> GetAllByUser(Expression<Func<Payment, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Payment>> GetAllOrderByDate()
        {
            throw new NotImplementedException();
        }
    }
}
