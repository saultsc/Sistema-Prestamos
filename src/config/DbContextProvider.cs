using Microsoft.EntityFrameworkCore;

namespace Sistema_Prestamos.src.data.sqlserver
{
    public class DbContextProvider
    {
        public PrestamoContext Context { get; private set; }

        public DbContextProvider()
        {
            var options = new DbContextOptionsBuilder<PrestamoContext>()
                .UseSqlServer("Server=DRAKE;Database=proyecto_prestamo;Integrated Security=True;TrustServerCertificate=True")
                .Options;

            Context = new PrestamoContext(options);
        }
    }
}
