﻿using System;
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


        public required string Name { get; set; }
        public string Cedula { get; set; } = string.Empty;
        public string Telefono { get; set; } = string.Empty;
        public string Representante { get; set; } = string.Empty;
        public required string Zonas { get; set; }
        public required string Agente { get; set; }
        public required string Cobrador {  get; set; }
        public required string Provincia { get; set; }
        public required string Localidad { get; set; }
        public required string Direcion { get; set; }
        public string Trabajo { get; set; } = string.Empty;
        public double Balance { get; set; } = 0.00;


        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
