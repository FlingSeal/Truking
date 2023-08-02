namespace Truking.Models
{
    public class CarModel
    {
        int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Series { get; set; }
        public string? Description { get; set; }

        public List<Car>? Cars { get; set;}
    }
}
