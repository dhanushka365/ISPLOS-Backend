using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.OrderAggregate
{
    public class ProductItemOrdered :BaseEntity
    {
        [Required]
        public Guid OrderId { get; set; } // Foreign key to the Order entity

        [Required]
        public Order Order { get; set; } // Navigation property to the Order entity

        [Required]
        public DateTimeOffset OrderDate { get; set; } = DateTimeOffset.Now;//used

        [Required]
        public decimal Subtotal { get; set; }//used
    }
}
