using System.ComponentModel.DataAnnotations;

namespace API.Dtos
{
    public class ProductToReturnDto
    {
        [Required]
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Range(0.10, 10000)]
        public decimal Price { get; set; }

        [Required]
        public string PictureUrl { get; set; }

        [Required]
        public Guid ProductTypeId { get; set; }

        [Required]
        public Guid ProductBrandId { get; set; }

        [Required]
        public string ProductTypeName { get; set; } // Add this property
        [Required]
        public string ProductBrandName { get; set; } // Add this property

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
