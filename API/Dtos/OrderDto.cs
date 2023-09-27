using Core.Entities.OrderAggregate;
using Core.Entities;

namespace API.Dtos
{
    public class OrderDto
    {
        public string BuyerEmail { get; set; }
        public DateTimeOffset OrderDate { get; set; } = DateTimeOffset.Now;
        public DeliveryMethod DeliveryMethod { get; set; }
        public IReadOnlyList<OrderItem> OrderItems { get; set; }
        public decimal Subtotal { get; set; }
        public OrderStatus Status { get; set; }//unpaid , paid , shipped , delivered , cancelled
        public string PaymentIntentId { get; set; }


        public ICollection<Payment> Payments { get; set; } // Add a collection of payments associated with this order
    }
}
