using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configurations
{
    public class PersonConfiguration : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.ToTable("персоны");

            builder.Property(s => s.Code)
                .HasColumnName("код");

            builder.HasKey(s => s.Code);
               

            builder.Property(s => s.LastName)
                .HasColumnName("Фамилия")
                .HasMaxLength(200)
                .HasDefaultValue(null);

            builder.Property(s => s.Name)
                .HasColumnName("Имя")
                .HasMaxLength(200)
                .HasDefaultValue(null);

            builder.Property(s => s.MiddleName)
                .HasColumnName("Отчество")
                .HasMaxLength(200)
                .HasDefaultValue(null);

            builder.Property(s => s.Sex)
                .HasColumnName("Пол")
                .IsRequired();

            builder.Property(s => s.BirthDate)
                .HasColumnName("Дата рожд").IsRequired();
            
            builder.Property(s => s.PassportNumber)
                .HasColumnName("Паспорт номер")
                .HasMaxLength(40)
                .HasDefaultValue(null);
            
            builder.Property(s => s.IssuedBy)
              .HasColumnName("Кем выдан")
              .HasMaxLength(200)
              .HasDefaultValue(null);

            builder.Property(s => s.PassportIssuedDate)
              .HasColumnName("Когда")
              .HasDefaultValue(null);

            builder.Property(s => s.IssuedPlace)
              .HasColumnName("Место")
              .HasMaxLength(16)
              .HasDefaultValue(null);

            builder.Property(s => s.IsCommand)
                .HasColumnName("isCommand")
                .IsRequired();

            builder.Property(s => s.Team)
              .HasColumnName("Команда")
              .HasDefaultValue(null);

            builder.Property(s => s._tex)
                .HasDefaultValue(null);

            builder.Property(s => s._texpr)
                .HasDefaultValue(null);

            builder.Property(s => s._sport)
                .HasDefaultValue(null);

            builder.Property(s => s._train)
                .HasDefaultValue(null);

            builder.Property(s => s._judge)
                .HasDefaultValue(null);

            builder.Property(s => s._zvan)
                .HasDefaultValue(null);

            builder.Property(s => s._org)
                .HasDefaultValue(null);

            builder.Property(s => s.CardType)
                .HasColumnName("Тип карты")
                .HasDefaultValue(null);

            builder.Property(s => s.CardNumber)
                .HasColumnName("Номер карты")
                .HasDefaultValue(null);

            builder.Property(s => s.CBDCode)
                .HasColumnName("КодЦБД")
                .HasDefaultValue(null);

            builder.Property(s => s.Payment)
               .HasColumnName("Взнос")
               .HasDefaultValue(null);

            builder.Property(s => s.Trainer)
                .HasMaxLength(500)
               .HasColumnName("Тренер")
               .HasDefaultValue(null);

            builder.Property(s => s.Department)
                .HasColumnName("Ведомство")
                .HasDefaultValue(null);

            builder.Property(s => s.Country)
               .HasColumnName("Страна")
               .HasDefaultValue(null);

            builder.Property(s => s.CodeEPC)
               .HasColumnName("КодЕРС")
               .HasDefaultValue(null);

            builder.Property(s => s.Parent)
               .HasColumnName("Родитель")
               .HasDefaultValue(null);

            builder.Property(s => s.Updated)
               .HasColumnName("updated")
               .HasDefaultValue(null);
        }
    }
}
