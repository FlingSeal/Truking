namespace Truking.Models
{
    public class Car
    {
        public string RegionCode { get; set; } = null!;
        public int Numder { get; set; }
        public string Series { get; set; } = null!;
        public Guid DriverId { get; set; }
        public int ModelId { get; set; }
        public int CategoryID { get; set; }
        public string? Color { get; set; }
        public int Tonnage { get; set; }
        public string? Description { get; set; }

        public Driver? Driver { get; set; }
        public CarModel? CarModel { get; set; }
        public Category? Category { get; set; }
    }
}
