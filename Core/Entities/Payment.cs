using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities.Identity;
using Core.Entities.OrderAggregate;

namespace Core.Entities
{
    public class Payment:BaseEntity
    {
        
        public string PaymentMethod { get; set; } // Name of the payment method (e.g., "Credit Card", "PayPal" ,"cash")
        public string PaymentMethodType { get; set; } // Type of the payment method (e.g., "Credit Card", "Online Payment")
        public string PaymentMethodDescription { get; set; } 
        public decimal Amount { get; set; } 
        public DateTime PaymentDate { get; set; }
        //public string TransactionId { get; set; } 
        public PaymentStatus PaymentStatus { get; set; }// Payment status (e.g., "Pending", "Completed")

        public ICollection<Order> Orders { get; set; } = new List<Order>();

        public Guid UserId { get; set; }

        public User User { get; set; }


    }
}
