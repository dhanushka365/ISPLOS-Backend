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
        public string BuyerEmail { get; set; }//used

        [Required]
        public Guid DeliveryMethodId { get; set; }//used

        [Required]
        public DeliveryMethod DeliveryMethod { get; set; }//used
        [Required]
        public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();//used

        [Required]
        // Change from OrderStatus to a collection of OrderStatus
        public ICollection<OrderStatus> OrderStatuses { get; set; } = new List<OrderStatus>();

        public ProductItemOrdered ProductItemOrdered { get; set; } // Navigation property to ProductItemOrdered

        [Required]
        public string PaymentIntentId { get; set; }

        [Required]
        public ICollection<Payment> Payments { get; set; } 


    }
}
