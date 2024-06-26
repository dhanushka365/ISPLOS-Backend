﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.OrderAggregate
{
    public class DeliveryMethod : BaseEntity
    {
        public string ShortName { get; set; } // 1. Add this property
        public string DeliveryTime { get; set; } // 2. Add this property
        public string Description { get; set; } // 3. Add this property
        public decimal deliveryPrice { get; set; } // 4. Add this property
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
