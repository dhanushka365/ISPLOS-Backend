using Core.Entities.OrderAggregate;
using Core.Entities;

namespace API.Dtos
{
    public class OrderProductObjectDTO
    {
        public decimal CurrentPrice { get; set; }
        public int Quantity { get; set; }

        public ProductDto Product { get; set; }
    }
}
