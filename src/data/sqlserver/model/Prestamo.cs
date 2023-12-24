using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Prestamos.src.data.sqlserver.model
{
    public class Prestamo
    {
        public int Id { get; set; }

        public int IdCliente { get; set; }
        public string NombreClient { get; set; }
        public string GarantiaPre { get; set; }
        public string FiadorPre { get; set; }
        public DateTime FechaPre { get; set; }
        public string TipoPre { get; set; }
        public int CuotasPre { get; set; }
        public int CuotasPagadaPre { get; set; } = 0;
        public double BalancePre { get; set; }
        public double MontoPre { get; set; }
        public double InteresPre { get; set; }
        public string DiaPre { get; set; }
        public string DiasCuotaPre { get; set; }
        public string EstadoPre { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

    }
}
