using Core.Entities.OrderAggregate;
using Core.Entities;

namespace API.Dtos
{
    public class OrderProductResponseDTO
    {

        public decimal CurrentPrice { get; set; }
        public int Quantity { get; set; }

        public Guid OrderId { get; set; }
        public Guid ProductId { get; set; }
       
        public DateTime CreatedAt { get; set; } 
        public DateTime UpdatedAt { get; set; }
    }
}
