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
        public decimal Amount { get; set; } 
        public DateTime PaymentDate { get; set; } = DateTime.Now;
   
        public Guid UserId { get; set; }

        public User User { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;


    }
}
