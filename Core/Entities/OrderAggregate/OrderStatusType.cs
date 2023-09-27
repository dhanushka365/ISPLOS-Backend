using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.OrderAggregate
{
    public class OrderStatusType :BaseEntity
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        // Navigation property to the collection of related OrderStatus instances
        public ICollection<OrderStatus> OrderStatuses { get; set; }
    }
}
