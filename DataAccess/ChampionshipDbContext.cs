using System;
using DataAccess.Configurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace DataAccess
{
    public class ChampionshipDbContext :DbContext
    {
        private readonly DatabaseOptions _options;
        public ChampionshipDbContext(IOptions<DatabaseOptions> options)
        {
            _options = options?.Value ?? throw new ArgumentNullException(nameof(options));
            if (string.IsNullOrWhiteSpace(options.Value.MySqlConnectionString))
            {
                throw new ArgumentNullException("Connection string is null or empty");
            }
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(_options.MySqlConnectionString, ServerVersion.AutoDetect(_options.MySqlConnectionString));
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ConfigureAllModels(modelBuilder);
            base.OnModelCreating(modelBuilder);
        }
        private void ConfigureAllModels(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new DisciplineConfiguration());
            modelBuilder.ApplyConfiguration(new AgeConfiguration());
            modelBuilder.ApplyConfiguration(new TourConfiguration());
            modelBuilder.ApplyConfiguration(new WeightConfiguration());
            modelBuilder.ApplyConfiguration(new TourTypeConfiguration());
            modelBuilder.ApplyConfiguration(new RatingConfiguration());
            modelBuilder.ApplyConfiguration(new PersonConfiguration());
            modelBuilder.ApplyConfiguration(new OkatoConfiguration());

        }
    }
}
