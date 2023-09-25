using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Identity
{
    public class User : IdentityUser<Guid>
    {
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        public string Avatar { get; set; }

        public Guid RoleId { get; set; }

        public Role Role { get; set; }

        public Address Address { get; set; }

    }
}
