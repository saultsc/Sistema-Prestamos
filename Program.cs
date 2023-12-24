using Sistema_Prestamos.src;
using Sistema_Prestamos.src.views;
using Sistema_Prestamos.src.views.Mantenimientos;
using Sistema_Prestamos.src.views.Procesos;

namespace Sistema_Prestamos
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new RegistroPrestamo());
        }
    }
}