namespace Truking.Models.Dto
{
    public class CarModelDto
    {
        int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Series { get; set; }
        public string? Description { get; set; }
    }
}
