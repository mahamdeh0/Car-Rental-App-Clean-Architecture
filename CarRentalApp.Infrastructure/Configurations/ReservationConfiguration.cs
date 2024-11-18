using CarRentalApp.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRentalApp.Infrastructure.Configurations
{
    public class ReservationConfiguration : IEntityTypeConfiguration<Reservation>
    {
        public void Configure(EntityTypeBuilder<Reservation> builder)
        {
            builder.Property(r => r.Id).HasColumnName("id");
            builder.Property(r => r.CarId).HasColumnName("car_id").IsRequired();
            builder.Property(r => r.UserId).HasColumnName("user_id").IsRequired();
            builder.Property(r => r.StartDate).HasColumnName("start_date").IsRequired();
            builder.Property(r => r.EndDate).HasColumnName("end_date").IsRequired();
            builder.Property(r => r.TotalCost).HasColumnName("total_cost").HasColumnType("decimal(18,2)");

            builder.HasOne<Car>()
                .WithMany()
                .HasForeignKey(r => r.CarId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne<User>()
                .WithMany()
                .HasForeignKey(r => r.UserId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
