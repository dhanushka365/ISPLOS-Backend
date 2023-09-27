using Core.Entities.Identity;

namespace API.Dtos
{
    public class UserDTO
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public string Avatar { get; set; }

     //   public Guid RoleId { get; set; }

    }
}
