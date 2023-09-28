using Core.Entities.OrderAggregate;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Dtos
{
    public class OrderStatusDto
    {
        [Required]
        public Guid Id { get; set; }
        public string Name { get; set; }

        public string Status { get; set; }

        public string StatusCode { get; set; }

        public string StatusMessage { get; set; }

        public Guid OrderStatusTypeId { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
