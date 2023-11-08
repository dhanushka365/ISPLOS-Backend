using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Rating
    {
        public Guid Id { get; set; }
        public int? ratingIndex { get; set; }
        public string? product { get; set; }
    }
}
