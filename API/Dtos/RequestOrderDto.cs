using System.ComponentModel.DataAnnotations;

namespace API.Dtos
{
    public class RequestOrderDto
    {
        [Required]
        public string BuyerEmail { get; set; }

        [Required]
        public string OrderDate { get; set; }

        [Required]
        public string DeliveryMethod { get; set; }

        [Required]
        public string OrderItems { get; set; }

        [Required]
        public decimal Subtotal { get; set; }

        [Required]
        public string Status { get; set; }

        [Required]
        public string PaymentIntentId { get; set; }

        [Required]
        public string Payments { get; set; }
    }
}
