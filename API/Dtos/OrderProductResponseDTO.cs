using Core.Entities.OrderAggregate;
using Core.Entities;

namespace API.Dtos
{
    public class OrderProductResponseDTO
    {
        public decimal CurrentPrice { get; set; }
        public int Quantity { get; set; }
        public ProductDto Product { get; set; }
        public DateTime CreatedAt { get; set; } 
        public DateTime UpdatedAt { get; set; }
    }
}
