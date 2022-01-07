using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Reservas.Entities;
using System;

namespace Reservas.DataAccess
{
    public class ApiDbContext : IdentityDbContext
    {
        public DbSet<Aerolinea> Aerolinea { get; set; }
        public DbSet<Aeropuerto> Aeropuerto { get; set; }
        public DbSet<Reserva> Reserva { get; set; }
        public DbSet<Tarifa> Tarifa { get; set; }
        public DbSet<Vuelo> Vuelo { get; set; }

        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Reserva>(
               dob =>
               {
                   dob.ToTable("Reservas");
               });

            //modelBuilder.Ignore<Reserva>();
            ////Validacion del modelo Reserva con llave primaria
            //modelBuilder.Ignore<Aerolinea>();
            //modelBuilder.Ignore<Aeropuerto>();
            //modelBuilder.Ignore<Tarifa>();
            //modelBuilder.Ignore<Vuelo>();
            //Validacion del modelo Aerolinea con llave primaria

            base.OnModelCreating(modelBuilder);
        }

    }
}
