using System.ComponentModel.DataAnnotations;

namespace API.Dtos
{
    public class ProductDto
    {
        [Required]
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public string PictureUrl { get; set; }

        [Required]
        public string ProductType { get; set; }

        [Required]
        public string ProductBrand { get; set; }
    }
}
