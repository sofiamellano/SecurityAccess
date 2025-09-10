namespace Backend.DataContext
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Service.Enums;
    using Service.Models;
    using System.Collections.Generic;

    public class RegistroAccesoContext : DbContext
    {
        public virtual DbSet<Alumno> Alumnos { get; set; }
        public RegistroAccesoContext() { }

        public RegistroAccesoContext(DbContextOptions<RegistroAccesoContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var configuration = new ConfigurationBuilder()
                    .AddJsonFile("appsettings.json")
                    .Build();
                string? cadenaConexion = configuration.GetConnectionString("mysqlRemoto");

                optionsBuilder.UseMySql(cadenaConexion, ServerVersion.AutoDetect(cadenaConexion));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Conversión de enums a string (para legibilidad en BD)

            modelBuilder.Entity<Alumno>()
                .Property(a => a.EstadoAlumno)
                .HasConversion<string>();
            #endregion

            #region Datos semilla simples

            // Alumnos demo
            modelBuilder.Entity<Alumno>().HasData(
                new Alumno { IdAlumno = 1, Dni = "12345678", Nombre = "Juan", Apellido = "Pérez", EstadoAlumno = EstadoAlumnoEnum.Activo },
                new Alumno { IdAlumno = 2, Dni = "87654321", Nombre = "Ana", Apellido = "García", EstadoAlumno = EstadoAlumnoEnum.Egresado },
                new Alumno { IdAlumno = 3, Dni = "11223344", Nombre = "Luis", Apellido = "Martínez", EstadoAlumno = EstadoAlumnoEnum.Suspendido }
            );

            #endregion
        }
    }
}
