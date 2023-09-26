using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.OrderAggregate
{
    public class OrderStatus : BaseEntity
    {
        //1- Pending
        //2- Processing
        //3- Shipped
        //4- Delivered
        //5- Cancelled
        //6- Refunded
        //7- Failed
        //8- Declined
        //9- Reversed
        //10- Chargeback
        //11- Unknown
        //12- Unpaid
        //13- Authorized
        //14- Partially Refunded
        //15- Voided
        //16- Expired
        //17- Incomplete
        //18- Processed
        //19- Disputed
        //20- Partially Paid
        //21- Marked for Review
        //22- Paid
        //23- Partially Charged
        //24- Refunded
        //25- Charged
        //26- Authorized
        //27- Pending

        public string Name { get; set; }

        public string Status { get; set; }

        public string StatusCode { get; set; }

        public string StatusMessage { get; set; }

        public string StatusType { get; set; }

        public string StatusDescription { get; set; }

        //public string StatusTypeCode { get; set; }

        //public string StatusTypeMessage { get; set; }

        //public string StatusTypeDescription { get; set; }


    }
}
