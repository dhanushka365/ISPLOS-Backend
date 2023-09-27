using System.ComponentModel.DataAnnotations;

namespace API.Dtos
{
    public class ProductBrandUpdateDto
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

    }
}
