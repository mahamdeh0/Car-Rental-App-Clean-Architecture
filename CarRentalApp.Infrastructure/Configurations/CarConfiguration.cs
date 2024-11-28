using CarRentalApp.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRentalApp.Infrastructure.Configurations
{
    public class CarConfiguration : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder.Property(c => c.Id).HasColumnName("id");
            builder.Property(c => c.Brand).HasColumnName("brand").HasMaxLength(100).IsRequired();
            builder.Property(c => c.Model).HasColumnName("model").HasMaxLength(100).IsRequired();
            builder.Property(c => c.PricePerDay).HasColumnName("price_per_day").HasColumnType("decimal(18,2)");
            builder.Property(c => c.IsAvailable).HasColumnName("is_available").IsRequired();
        }
    }
}