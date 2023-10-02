using Core.Entities.OrderAggregate;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace Core.Interfaces
{
    public interface IPaymentRepository : IGenericRepository<Payment>
    {
      //Task<IEnumerable<Payment>> GetAllOrderByDate();

      Task<IEnumerable<Payment>> GetAllByUser(Expression<Func<Payment, bool>> expression);
    }
}
