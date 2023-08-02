using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Truking.Models;

namespace Truking.Data.EntityConfig
{
    public class CarModelEntityTypeConfig : IEntityTypeConfiguration<CarModel>
    {
        public void Configure(EntityTypeBuilder<CarModel> builder)
        {
            builder.HasMany(d => d.Cars)
               .WithOne(d => d.CarModel)
               .HasForeignKey(d => d.ModelId)
               .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
