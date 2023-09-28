using Core.Entities.Identity;
using Core.Entities.OrderAggregate;
using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace API.Dtos
{
    public class RequestOrderDto
    {
        [Required]
        public Guid DeliveryMethodId { get; set; }//used
        [Required]
        public DateTimeOffset OrderDate { get; set; } = DateTimeOffset.Now;//used

        [Required]
        public DeliveryMethod DeliveryMethod { get; set; }//used
        [Required]
        public ICollection<OrderProduct> OrderItems { get; set; } = new List<OrderProduct>();//used

        [Required]

        public ICollection<OrderStatus> OrderStatuses { get; set; } = new List<OrderStatus>();

        public int PaymentId { get; set; }
        public Payment Payment { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
