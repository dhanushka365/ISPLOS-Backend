using System.ComponentModel.DataAnnotations;

namespace API.Dtos
{
    public class RequestRatingDto
    {
        [Required]
        [Range(0, 10)]
        public int? ratingIndex { get; set; }
        [Required]
        public string? product { get; set; }
    }
}
