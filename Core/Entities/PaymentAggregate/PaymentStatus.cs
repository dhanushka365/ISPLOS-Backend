using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities.PaymentAggregate;

namespace Core.Entities
{
    public class PaymentStatus :BaseEntity
    {
        public string Name { get; set; }

        public string Status { get; set; }

        public string StatusCode { get; set; }

        public string StatusMessage { get; set; }

        // Collection of payments associated with this status
        public ICollection<Payment> Payments { get; set; } = new List<Payment>();

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
