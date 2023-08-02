using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Truking.Models;

namespace Truking.Data.EntityConfig
{
    public class DriverEntityTypeConfig : IEntityTypeConfiguration<Driver>
    {
        public void Configure(EntityTypeBuilder<Driver> builder)
        {
            builder.HasMany<Car>(c => c.Cars)
                .WithOne(d => d.Driver)
                .HasForeignKey(c => c.DriverId);
        }
    }
}
