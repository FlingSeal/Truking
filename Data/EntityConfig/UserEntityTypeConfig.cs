using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Truking.Models;

namespace Truking.Data.EntityConfig
{
    public class UserEntityTypeConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {

            builder.HasOne(u => u.Driver)
                .WithOne(p => p.User)
                .HasForeignKey<Driver>(p => p.UserId)
                .OnDelete(DeleteBehavior.Cascade); 
        }
    }
}
