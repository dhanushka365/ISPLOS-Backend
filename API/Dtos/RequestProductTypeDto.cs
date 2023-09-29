using System.ComponentModel.DataAnnotations;

namespace API.Dtos
{
    public class RequestProductTypeDto
    {
        [Required]
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

    }
}
