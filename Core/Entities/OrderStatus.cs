using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class OrderStatus :BaseEntity
    {
        public string Name { get; set; }

        public string Status { get; set; }

        public string StatusCode { get; set; }

        public string StatusMessage { get; set; }

        public string StatusType { get; set; }

        public string StatusDescription { get; set; }

        public string StatusTypeCode { get; set; }

        public string StatusTypeMessage { get; set; }

        public string StatusTypeDescription { get; set; }


    }
}
