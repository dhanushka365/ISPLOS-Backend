using Core.Entities.OrderAggregate;
using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace API.Dtos
{
    public class OrderDto
    {
        [Required]
        public Guid Id { get; set; }

        //[Required]
        //public string BuyerEmail { get; set; }

        //[Required]
        //public DateTimeOffset OrderDate { get; set; } = DateTimeOffset.Now;

        //[Required]
        //public DeliveryMethod DeliveryMethod { get; set; }

        //[Required]
        //public IReadOnlyList<OrderItem> OrderItems { get; set; }

        //[Required]
        //public decimal Subtotal { get; set; }

        //[Required]
        //public OrderStatus Status { get; set; }//unpaid , paid , shipped , delivered , cancelled

        //[Required]
        //public string PaymentIntentId { get; set; }

        //[Required]
        //public ICollection<Payment> Payments { get; set; } // Add a collection of payments associated with this order

        [Required]
        public string BuyerEmail { get; set; }

        [Required]
        public DateTimeOffset OrderDate { get; set; } = DateTimeOffset.Now;

        [Required]
        public string DeliveryMethod { get; set; }

        [Required]
        public string OrderItems { get; set; }

        [Required]
        public decimal Subtotal { get; set; }

        [Required]
        public string Status { get; set; }

        [Required]
        public string PaymentIntentId { get; set; }

        [Required]
        public string Payments { get; set; }
    }
}
