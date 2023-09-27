using System.ComponentModel.DataAnnotations;

namespace API.Dtos
{
    public class productTypeUpdateDto
    {
        [Required]
        public string Name { get; set; }
    }
}
