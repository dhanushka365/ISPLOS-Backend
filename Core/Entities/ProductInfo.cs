using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class ProductInfo
    {
        public string ProductName { get; set; }
        public Guid ProductIds { get; set; }
        public decimal Price { get; set; }
        public int TotalQuantity { get; set; }
    }
}
