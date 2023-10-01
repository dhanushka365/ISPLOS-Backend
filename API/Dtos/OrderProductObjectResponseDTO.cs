using Core.Entities.Identity;
using Core.Entities.OrderAggregate;
using System.ComponentModel.DataAnnotations;

namespace API.Dtos
{
    public class OrderProductObjectResponseDTO
    {

        public Guid Id { get; set; }

        [Required]
        public string OrderDate { get; set; }

        [Required]
        public Guid UserID { get; set; }
        public UserMinimumDataDTO User { get; set; }

        public bool IsPaid { get; set; } = false;

         public List<OrderProductObjectDTO> OrderProducts { get; set; } 



        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}
