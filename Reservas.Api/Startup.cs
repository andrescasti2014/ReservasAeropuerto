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
using Reservas.Abstraction;
using Reservas.Application;
using Reservas.DataAccess;
using Reservas.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reservas.Api
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
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Reservas.WebApi", Version = "v1" });
            });

            services.AddDbContext<ApiDbContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"), b => b.MigrationsAssembly("Reservas.WebApi")));
            services.AddScoped(typeof(IApplicationReserva<>), typeof(Reserva<>));
            services.AddScoped(typeof(IRepositoryReserva<>), typeof(RepositoryReserva<>));
            services.AddScoped(typeof(IDbContext<>), typeof(ReservaDbContext<>));
            ////Endpoint Aerolinea
            //services.AddScoped(typeof(IApplicationAerolinea<>), typeof(Aerolinea<>));
            //services.AddScoped(typeof(IRepositoryAerolinea<>), typeof(RepositoryAerolinea<>));
            //services.AddScoped(typeof(IDbContext<>), typeof(AerolineaDbContext<>));
            //////Endpoint Aeropuerto
            //services.AddScoped(typeof(IApplicationAeropuerto<>), typeof(Aeropuerto<>));
            //services.AddScoped(typeof(IRepositoryAeropuerto<>), typeof(RepositoryAeropuerto<>));
            //services.AddScoped(typeof(IDbContext<>), typeof(AeropuertoDbContext<>));
            //////Endpoint Tarifa
            //services.AddScoped(typeof(IApplicationTarifa<>), typeof(Tarifa<>));
            //services.AddScoped(typeof(IRepositoryTarifa<>), typeof(RepositoryTarifa<>));
            //services.AddScoped(typeof(IDbContext<>), typeof(TarifaDbContext<>));
            //////Endpoint Vuelo
            //services.AddScoped(typeof(IApplicationVuelo<>), typeof(Vuelo<>));
            //services.AddScoped(typeof(IRepositoryVuelo<>), typeof(RepositoryVuelo<>));
            //services.AddScoped(typeof(IDbContext<>), typeof(VueloDbContext<>));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Reservas.WebApi v1"));
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
