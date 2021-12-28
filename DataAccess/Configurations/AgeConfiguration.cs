using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configurations
{
    public class AgeConfiguration : IEntityTypeConfiguration<Age>
    {
        public void Configure(EntityTypeBuilder<Age> builder)
        {
            builder.ToTable("возраста");

            builder.Property(s => s.Code)
                .HasColumnName("Код");

            builder.HasKey(s => s.Code);
                

            builder.Property(s => s.Name)
                .HasColumnName("Название")
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(s => s.Sex)
                .HasColumnName("Пол")
                .IsRequired();

            builder.Property(s => s.C)
                .HasColumnName("С")
                .IsRequired();

            builder.Property(s => s.PO)
                .HasColumnName("По")
                .IsRequired();

            builder.Property(s => s.Team)
                .HasColumnName("Команды")
                .IsRequired();
        }
    }
}
