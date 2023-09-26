using System.ComponentModel.DataAnnotations;

namespace API.Dtos
{
    public class RoleDTO
    {
        [Required]
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
