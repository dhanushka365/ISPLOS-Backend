using System.ComponentModel.DataAnnotations;

namespace API.Dtos
{
    public class RequestProductBrandDto
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    }
}
