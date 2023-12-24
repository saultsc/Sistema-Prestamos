using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Prestamos.src.data.sqlserver.model
{
    public class Ingreso
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int IdPrestamo { get; set; }
        public string ClienteNombre { get; set; } = null!;
        public int IdCliente { get; set; }
        public double dinero { get; set; }


        public DateTime CreatedAt { get; set; }
    }
}
