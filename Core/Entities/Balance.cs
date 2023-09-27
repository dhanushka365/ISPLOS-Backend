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

  
        [ForeignKey("CreatedByUserId")]
        public Guid CreatedByUserId { get; set; }

        
        public User CreatedByUser { get; set; }

        [ForeignKey("UpdatedByUserId")]
        public Guid UpdatedByUserId { get; set; }

        public User UpdatedByUser { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }



    }
}
