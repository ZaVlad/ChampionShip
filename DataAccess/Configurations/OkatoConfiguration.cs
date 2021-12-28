using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configurations
{
    class OkatoConfiguration : IEntityTypeConfiguration<Okato>
    {
        public void Configure(EntityTypeBuilder<Okato> builder)
        {
            builder.ToTable("okato");

            builder.HasKey(s=>s.Id);

            builder.Property(s => s.Name).HasMaxLength(200);
                
            builder.Property(s => s.Reduction).HasColumnName("Сокр")
                .HasMaxLength(10)
                .IsRequired();

            builder.Property(s => s.Type)
                .IsRequired();

            builder.Property(s => s.Updated).HasColumnName("updated")
                .IsRequired();


        }
    }
}
