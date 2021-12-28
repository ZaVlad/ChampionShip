using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configurations
{
    public class RatingConfiguration : IEntityTypeConfiguration<Rating>
    {
        public void Configure(EntityTypeBuilder<Rating> builder)
        {
            builder.ToTable("оценки");

            builder.Property(s => s.Code)
                .HasColumnName("Код");

            builder.HasKey(s => s.Code);

            builder.Property(s => s.Net).HasColumnName("Сетка").IsRequired();

            builder.HasOne(s => s.Person)
                .WithMany()
                .HasForeignKey(s => s.PersonId)
                .IsRequired();

            builder.Property(s => s.PersonId)
                .HasColumnName("Участник");


            builder.Property(s => s.Updated).IsRequired();

        }
    }
}
