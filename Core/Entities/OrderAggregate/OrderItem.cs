using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.OrderAggregate
{
    public class OrderItem : BaseEntity
    {
        //public ProductItemOrdered ItemOrdered { get; set; }
        public decimal CurrentPrice { get; set; }
        public int Quantity { get; set; }       
        public Guid OrderId { get; set; }
        public Order Order { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
