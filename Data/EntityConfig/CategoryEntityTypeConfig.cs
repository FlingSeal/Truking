using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Truking.Models;

namespace Truking.Data.EntityConfig
{
    public class CategoryEntityTypeConfig : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasMany<Car>(c => c.Cars)
                .WithOne(c => c.Category)
                .HasForeignKey(c => c.CategoryID)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
