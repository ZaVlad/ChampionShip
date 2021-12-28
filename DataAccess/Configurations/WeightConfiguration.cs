using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configurations
{
    public class WeightConfiguration : IEntityTypeConfiguration<Weight>
    {
        public void Configure(EntityTypeBuilder<Weight> builder)
        {
            builder.ToTable("веса");

            builder.Property(s => s.Code)
                .HasColumnName("Код");
            builder.HasKey(s => s.Code);

            builder.Property(s => s.Name)
                .HasColumnName("Название")
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(s => s.Order)
                .HasColumnName("Порядок")
                .IsRequired();
        }
    }
}
