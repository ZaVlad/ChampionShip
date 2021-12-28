using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configurations
{
    public class TourTypeConfiguration : IEntityTypeConfiguration<TourType>
    {
        public void Configure(EntityTypeBuilder<TourType> builder)
        {
            builder.ToTable("tour_type");

            builder.Property(s => s.Id)
               .HasColumnName("id");

            builder.HasKey(s => s.Id);

            builder.Property(s => s.Name)
                .HasColumnName("name")
                .HasMaxLength(500)
                .IsRequired();

            builder.Property(s => s.Short)
                .HasColumnName("short")
                .HasMaxLength(500)
                .IsRequired();

        }
    }
}
