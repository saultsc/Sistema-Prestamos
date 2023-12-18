using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Sistema_Prestamos.src.data.sqlserver.model;
using Sistema_Prestamos.src.views.Mantenimientos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Prestamos.src.data.sqlserver
{
    public class PrestamoContext : DbContext
    {
        public PrestamoContext() { }

        public PrestamoContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer("Server=.;Database=proyecto_prestamo;Integrated Security=True;TrustServerCertificate=True")
                .LogTo(Console.WriteLine, LogLevel.Information);
        }

        public DbSet<Usuario> Usuarios => Set<Usuario>();
        public DbSet<Zona> Zona => Set<Zona>();
        public DbSet<Cobrador> Cobrador => Set<Cobrador>();
        public DbSet<Direccion> Direccion => Set<Direccion>();
        public DbSet<Cliente> Cliente => Set<Cliente>();
        public DbSet<Agente> Agente => Set<Agente>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Usuario>().ToTable("Usuario");
            modelBuilder.Entity<Usuario>()
                .Property(u => u.CreatedAt)
                .HasDefaultValueSql("GETDATE()");

            modelBuilder.Entity<Zona>()
               .Property(u => u.CreatedAt)
               .HasDefaultValueSql("GETDATE()");

            modelBuilder.Entity<Cobrador>()
               .Property(u => u.CreatedAt)
               .HasDefaultValueSql("GETDATE()");

            modelBuilder.Entity<Direccion>()
               .Property(u => u.CreatedAt)
               .HasDefaultValueSql("GETDATE()");

            modelBuilder.Entity<Cliente>()
               .Property(u => u.CreatedAt)
               .HasDefaultValueSql("GETDATE()");

            modelBuilder.Entity<Agente>()
               .Property(u => u.CreatedAt)
               .HasDefaultValueSql("GETDATE()");
        }

    }
}
