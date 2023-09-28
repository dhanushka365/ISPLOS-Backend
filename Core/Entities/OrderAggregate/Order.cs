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
        [DataType(DataType.Date)]

        public DateTime OrderDate { get; set; } 


        public Guid DeliveryMethodId { get; set; }//used
        public DeliveryMethod DeliveryMethod { get; set; }//used


        [Required]
        public Guid UserID { get; set; }
        public User User { get; set; }



        [Required]
        public Guid OrderStatusId { get; set; }
        public OrderStatus OrderStatus { get; set; }



        public IList<OrderProduct> OrderProducts { get; set; } //used


        
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;


    }
}
