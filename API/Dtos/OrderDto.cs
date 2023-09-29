using Core.Entities.OrderAggregate;
using System.ComponentModel.DataAnnotations;
using Core.Entities.Identity;
using Core.Entities;

namespace API.Dtos
{
    public class OrderDto
    {
        [Required]
        public Guid Id { get; set; }

        [Required]
        public Guid DeliveryMethodId { get; set; }//used
        [Required]
        public DateTimeOffset OrderDate { get; set; } = DateTimeOffset.Now;//used

        [Required]
        public DeliveryMethod DeliveryMethod { get; set; }//used
        [Required]
        public ICollection<OrderProduct> OrderItems { get; set; } = new List<OrderProduct>();//used

        [Required]
        public User User { get; set; }

        [Required]

        public ICollection<OrderStatus> OrderStatuses { get; set; } = new List<OrderStatus>();

        public int PaymentId { get; set; }
        public Payment Payment { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }=DateTime.Now;
    }
}
