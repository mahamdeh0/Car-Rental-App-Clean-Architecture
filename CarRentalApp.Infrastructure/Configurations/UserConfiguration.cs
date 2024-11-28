using CarRentalApp.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRentalApp.Infrastructure.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(u => u.Id).HasColumnName("id");
            builder.Property(u => u.FirstName).HasColumnName("first_name").HasMaxLength(50).IsRequired();
            builder.Property(u => u.LastName).HasColumnName("last_name").HasMaxLength(50).IsRequired();
            builder.Property(u => u.Email).HasColumnName("email").HasMaxLength(100).IsRequired();
            builder.Property(u => u.PasswordHash).HasColumnName("password_hash").IsRequired();
            builder.Property(u => u.PhoneNumber).HasColumnName("phone_number").HasMaxLength(15);
            builder.Property(u => u.DateOfBirth).HasColumnName("date_of_birth");
            builder.Property(u => u.AddressLine1).HasColumnName("address_line1").HasMaxLength(100);
            builder.Property(u => u.AddressLine2).HasColumnName("address_line2").HasMaxLength(100);
            builder.Property(u => u.City).HasColumnName("city").HasMaxLength(50);
            builder.Property(u => u.Country).HasColumnName("country").HasMaxLength(50);
            builder.Property(u => u.DriversLicenseNumber).HasColumnName("drivers_license_number").HasMaxLength(50);
        }
    }
}