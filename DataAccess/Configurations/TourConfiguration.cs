using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configurations
{
    public class TourConfiguration : IEntityTypeConfiguration<Tour>
    {
        public void Configure(EntityTypeBuilder<Tour> builder)
        {
            builder.ToTable("tour");
            builder.Property(s => s.Code)
                .HasColumnName("Код");

            builder.HasKey(s=>s.Code);

            builder.Property(s => s.GroupName)
                .HasMaxLength(50)
                .IsRequired();


            builder.Property(s => s.DisciplineId)
              .HasColumnName("Дисциплина");

            builder.HasOne(s => s.TourType)
                .WithMany()
                .HasForeignKey(s => s.Number)
                .IsRequired();

            builder.HasOne(s => s.Discipline)
                .WithMany(s=>s.Tours)
                .HasForeignKey(s => s.DisciplineId)
                .IsRequired();

            builder.Property(s => s.OrderNumber)
                .IsRequired();

            builder.Property(s => s.CountLimit)
                .IsRequired();

            builder.Property(s => s.Updated)
                .HasColumnName("updated")
                .IsRequired();
        }
    }
}
