using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Sistema_Prestamos.src.data.sqlserver.model;
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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Usuario>().ToTable("Usuario");
            modelBuilder.Entity<Usuario>()
                .Property(u => u.CreatedAt)
                .HasDefaultValueSql("GETDATE()");
        }

    }
}
