using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Truking.Models;

namespace Truking.Data.EntityConfig
{
    public class DriverStatusEntityTypeConfig : IEntityTypeConfiguration<DriverStatus>
    {
        public void Configure(EntityTypeBuilder<DriverStatus> builder)
        {
            builder.HasMany(d => d.Drivers)
               .WithOne(d => d.DriverStatus)
               .HasForeignKey(d => d.DriverStatusId)
               .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
