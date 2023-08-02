namespace Truking.Models
{
    public class DriverStatus
    {
        public int Id { get; set; }
        public string Staus { get; set; } = null!;

        public List<Driver>? Drivers { get; set; }
    }
}
