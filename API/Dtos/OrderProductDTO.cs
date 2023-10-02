namespace API.Dtos
{
    public class OrderProductDTO
    {
        public Guid ProductID { get; set; }

        public int Quantity { get; set; } = 1;
    }
}
