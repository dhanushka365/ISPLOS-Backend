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
        public ICollection<OrderProduct> OrderItems { get; set; } = new List<OrderProduct>();//used

        [Required]
        public User User { get; set; }

        [Required]
       
        public ICollection<OrderStatus> OrderStatuses { get; set; } = new List<OrderStatus>();

        public int PaymentId { get; set; }
        public Payment Payment { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }


    }
}
