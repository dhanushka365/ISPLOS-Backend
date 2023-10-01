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
        
        public string OrderDate { get; set; }  = DateTime.Now.ToShortDateString();

        [Required]
        public Guid UserID { get; set; }
        public User User { get; set; }


        public bool IsPaid { get; set; } = false;


        // [Required]
        //  public Guid OrderStatusId { get; set; }
        //  public OrderStatus OrderStatus { get; set; }

        //  public Guid DeliveryMethodId { get; set; }//used
        //  public DeliveryMethod DeliveryMethod { get; set; }//used


        public IList<OrderProduct> OrderProducts { get; set; } //used


        
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;


    }
}
