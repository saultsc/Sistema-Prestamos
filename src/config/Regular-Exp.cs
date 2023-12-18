using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Sistema_Prestamos.src.config
{
    public class Regular_Exp
    {
        public static bool IsValidEmail(string email)
        {
            try
            {
                // La expresión regular para validar direcciones de correo electrónico
                string pattern = @"^[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,}$";

                // Verifica si el formato del correo electrónico es válido
                bool isValid = Regex.IsMatch(email, pattern);

                return isValid;
            }
            catch (RegexMatchTimeoutException)
            {
                // Manejo de excepciones para expresiones regulares
                return false;
            }
        }
    }
}
