using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.OrderAggregate
{
    public class OrderStatus :BaseEntity
    {
      
        public string Name { get; set; }

        public string Status { get; set; }

        public string StatusCode { get; set; }

        public string StatusMessage { get; set; }

        public Guid OrderStatusTypeId { get; set; }
        public OrderStatusType OrderStatusType { get; set; }

        //public Guid OrderId { get; set; }
        //public Order Order { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }


    }
}
