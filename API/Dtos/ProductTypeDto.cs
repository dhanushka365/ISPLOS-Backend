using System.ComponentModel.DataAnnotations;

namespace API.Dtos
{
    public class ProductTypeDto
    {
        [Required]
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
