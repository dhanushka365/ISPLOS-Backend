using Core.Entities.OrderAggregate;
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

        public Guid UserId { get; set; }

        public string Name { get; set; }

        public string Avatar { get; set; }

        public Guid RoleId { get; set; }

        public Role Role { get; set; }

        // Navigation property to represent the user's orders
        public ICollection<Order> Orders { get; set; } = new List<Order>();

        // Navigation property to represent the user's payments
        public ICollection<Payment> Payments { get; set; } = new List<Payment>();
    }
}
