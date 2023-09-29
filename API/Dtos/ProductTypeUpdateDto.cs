using System.ComponentModel.DataAnnotations;

namespace API.Dtos
{
    public class productTypeUpdateDto
    {
        [Required]
        public string Name { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }=DateTime.Now;
    }
}
