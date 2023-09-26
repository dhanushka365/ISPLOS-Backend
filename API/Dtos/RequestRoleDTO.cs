using System.ComponentModel.DataAnnotations;

namespace API.Dtos
{
    public class RequestRoleDTO
    {
        [Required]
        public string Name { get; set; }
    }
}
