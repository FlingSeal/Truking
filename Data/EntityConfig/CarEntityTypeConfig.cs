using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Truking.Models;

namespace Truking.Data.EntityConfig
{
    public class CarEntityTypeConfig : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder.HasKey(c => new { c.RegionCode, c.Numder, c.Series });
        }
    }
}
