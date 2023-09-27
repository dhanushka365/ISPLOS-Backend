using System.ComponentModel.DataAnnotations;

namespace API.Dtos
{
    public class RequestProductBrandDto
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }
    }
}
