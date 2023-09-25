using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.OrderAggregate
{
    public class OrderItem : BaseEntity
    {
        public OrderItem()
        {
        }

        public OrderItem(ProductItemOrdered itemOrdered, decimal currentPrice, int quantity)
        {
            ItemOrdered = itemOrdered; // 1. Add this line
            CurrentPrice = currentPrice; // 2. Add this line
            Quantity = quantity; // 3. Add this line
        }
        public ProductItemOrdered ItemOrdered { get; set; }
        public decimal CurrentPrice { get; set; }
        public int Quantity { get; set; }
    }
}
