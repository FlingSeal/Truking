

namespace Truking.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Surename { get; set; }
        public string? Patronymic { get; set; }
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public long Phone { get; set; }
        public int Rating { get; set; }
        public int RoleId { get; set; }

        public Role? Role { get; set; }
        public Driver? Driver { get; set; }
    }
}
