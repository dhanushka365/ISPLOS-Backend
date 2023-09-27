using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities.Identity;

namespace Core.Entities
{
    public class Balance:BaseEntity
    {


        public double remainBalance { get; set; }

        [ForeignKey("UserId")]
        public Guid UserId { get; set; }

        public User User { get; set; }

        // Foreign key for CreatedByUser
        [ForeignKey("CreatedByUserId")]
        public Guid CreatedByUserId { get; set; }

        // Navigation property for CreatedByUser
        public User CreatedByUser { get; set; }

        // Foreign key for UpdatedByUser
        [ForeignKey("UpdatedByUserId")]
        public Guid UpdatedByUserId { get; set; }

        // Navigation property for UpdatedByUser
        public User UpdatedByUser { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }



    }
}
