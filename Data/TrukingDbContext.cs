using Microsoft.EntityFrameworkCore;
using Truking.Data.EntityConfig;
using Truking.Models;

namespace Truking.Data
{
    public class TrukingDbContext:DbContext
    {
        public DbSet<User>? Users { get; set; }
        public DbSet<Driver> Drivers { get; set; }
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
