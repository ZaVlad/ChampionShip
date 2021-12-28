using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configurations
{
    public class DisciplineConfiguration : IEntityTypeConfiguration<Discipline>
    {
        public void Configure(EntityTypeBuilder<Discipline> builder)
        {
            builder.ToTable("дисциплины");

            builder.Property(s => s.Code)
                .HasColumnName("Код");

            builder.HasKey(s => s.Code);
                

            builder.HasOne(s => s.Age)
                .WithMany()
                .HasForeignKey(s => s.AgeId)
                .IsRequired();

            builder.Property(s => s.AgeId)
                .HasColumnName("Возраст")
                .IsRequired();

            builder.HasOne(s => s.Weight)
                .WithMany()
                .HasForeignKey(s => s.WeightId)
                .IsRequired();

            builder.Property(s => s.WeightId)
                .HasColumnName("Вес")
                .IsRequired();

            builder.Property(s => s.Standart)
                .HasColumnName("Стандарт")
                .IsRequired();

        }
    }
}
