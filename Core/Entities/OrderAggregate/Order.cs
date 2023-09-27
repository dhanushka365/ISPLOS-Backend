using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities.Identity;

namespace Core.Entities.OrderAggregate
{
    public class Order : BaseEntity
    {

        [Required]
        public Guid DeliveryMethodId { get; set; }//used
        [Required]
        public DateTimeOffset OrderDate { get; set; } = DateTimeOffset.Now;//used

        [Required]
        public DeliveryMethod DeliveryMethod { get; set; }//used
        [Required]
        public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();//used

        [Required]
        // Reference to the User who placed the order
        public User User { get; set; }

        [Required]
       
        public ICollection<OrderStatus> OrderStatuses { get; set; } = new List<OrderStatus>();

        // Other order properties.

        public int PaymentId { get; set; }
        public Payment Payment { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }


    }
}
