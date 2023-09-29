using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace API.Dtos
{
    public class RequestProductDto
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        [Range(0.10, 10000.00)]
        public decimal Price { get; set; }

        [Required]
        public string PictureUrl { get; set; }

        //[Required]
        //public Guid ProductTypeId { get; set; }


        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

        //[Required]
        //public Guid ProductBrandId { get; set; }

    }
}
