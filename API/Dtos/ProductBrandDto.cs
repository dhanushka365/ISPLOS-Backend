using System.ComponentModel.DataAnnotations;

namespace API.Dtos
{
    public class ProductBrandDto
    {
        [Required]
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }
    }
}
