using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Identity
{
    public class Role : IdentityRole<Guid>
    {
        [Required]
        public override Guid Id { get; set; }

        [Required]
        public override string Name { get; set; }
    }
}
