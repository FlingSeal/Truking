using Microsoft.EntityFrameworkCore;
using Truking.Data.EntityConfig;
using Truking.Models;

namespace Truking.Data
{
    public class TrukingDbContext:DbContext
    {
        public DbSet<User>? Users { get; set; }
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<DriverStatus> DriverStatuses { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<CarModel> CarModels { get; set; }
        public DbSet<Category> Categories { get; set; }
        public TrukingDbContext(DbContextOptions options):base(options) 
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserEntityTypeConfig());                
        }
    }
}
