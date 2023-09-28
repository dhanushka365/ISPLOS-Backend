namespace API.Dtos
{
    public class RequestOrderStatusDto
    {
        public string Name { get; set; }

        public string Status { get; set; }

        public string StatusCode { get; set; }

        public string StatusMessage { get; set; }

        public Guid OrderStatusTypeId { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
