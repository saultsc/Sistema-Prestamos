using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Prestamos.src.data.sqlserver.model
{
    public class Cliente
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }


        public required string Nombre { get; set; }
        public string Cedula { get; set; } = string.Empty;
        public string Telefono { get; set; } = string.Empty;
        public string Representante { get; set; } = string.Empty;
        public string Zonas { get; set; }
        public string Agente { get; set; }
        public string Cobrador { get; set; }
        public string Provincia { get; set; }
        public string Localidad { get; set; }
        public string Direcion { get; set; }
        public string Trabajo { get; set; } = string.Empty;
        public double Balance { get; set; } = 0.00;


        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }


        public static Cliente Create(int  Id, string nombre, string cedula, string telefono /* Otros parámetros */)
        {
            return new Cliente
            {
                Id = Id,
                Nombre = nombre,
                Cedula = cedula,
                Telefono = telefono,
                
            };
        }
    }
}
