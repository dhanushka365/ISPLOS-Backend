using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Balance
    {

        public Guid Id { get; set; }

        public double Amount { get; set; }

        public Guid UserId { get; set; }

        public User User { get; set; }

    }
}
