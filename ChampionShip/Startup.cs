using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using Aplication.Repositories;
using Intefaces.Application.Repositories;
using Intefaces.Implementation.Interfaces;
using ChampionShip.Configuration;
using DataAccess;

namespace ChampionShip
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllers();
            services.Configure<DatabaseOptions>(Configuration.GetSection("DatabaseOptions"));
            services.AddDbContext<ChampionshipDbContext>();

            services.AddTransient<IDiscplineRepository, DisciplineRepository>();
            services.AddTransient<IWeightRepository, WeightRepository>();
            services.AddTransient<IPersonRepository, PersonRepository>();
            services.AddTransient<IRatingRepository, RatingRepository>();
            services.AddTransient<ITourRepository, TourRepository>();
            //GlobalConfiguration.Configuration.MessageHandlers.Add(new OptionsHttpMessageHandler());


            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "ChampionShip", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "ChampionShip v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
