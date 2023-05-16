using DomainLayer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace DomainLayer.Configurations
{
    public class CountryConfiguration : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.Property(m => m.Name).IsRequired().HasMaxLength(100);
            builder.Property(m => m.SoftDelete).IsRequired().HasDefaultValue(false);
            builder.Property(m => m.CreatedAt).IsRequired().HasDefaultValue(DateTime.UtcNow);
        }
    }
}
