using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Payment:BaseEntity
    {
        
        public string PaymentMethod { get; set; } // Name of the payment method (e.g., "Credit Card", "PayPal")
        public string PaymentMethodType { get; set; } // Type of the payment method (e.g., "Credit Card", "Online Payment")
        public string PaymentMethodDescription { get; set; } // Description or additional information about the payment method
        public decimal Amount { get; set; } // Payment amount
        public DateTime PaymentDate { get; set; } // Date and time of the payment
        public string TransactionId { get; set; } 
        public string Status { get; set; } // Payment status (e.g., "Pending", "Completed")
        public string BuyerEmail { get; set; } 

        
        public int OrderId { get; set; }// Foreign key referencing the Order
      
        public Order Order { get; set; }  // Navigation property to access the related Order object


    }
}
