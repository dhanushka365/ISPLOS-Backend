namespace API.Dtos
{
    public class ProductStatDTO
    {
        public string ProductName { get; set; }
        public Guid ProductIds { get; set; }
        public decimal Price { get; set; }
        public int TotalQuantity { get; set; }
    }
}
