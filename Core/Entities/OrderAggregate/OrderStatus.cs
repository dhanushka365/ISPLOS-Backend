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

        // Foreign key property
        public Guid OrderStatusTypeId { get; set; }

        // Navigation property to the related OrderStatusType
        [ForeignKey("OrderStatusTypeId")]
        public OrderStatusType OrderStatusType { get; set; }

        public Guid OrderId { get; set; }
        public Order Order { get; set; }


    }
}
