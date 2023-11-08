namespace API.Dtos
{
    public class RatingDto
    {
        public Guid Id { get; set; }
        public int? ratingIndex { get; set; }
        public string? product { get; set; }
    }
}
