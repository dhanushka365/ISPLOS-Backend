using System.ComponentModel.DataAnnotations;

namespace API.Dtos
{
    public class RequestProductTypeDto
    {
        [Required]
        public string Name { get; set; }


    }
}
