using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Prestamos.src.data.sqlserver.model
{
    public class Usuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }


        public string Name { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string Level_acces { get; set; } = null!;


        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public static Usuario crate(string name, string email, string password, string levelAcess)
        {
            return new Usuario
            {
                Name = name,
                Email = email,
                Password = password,
                Level_acces = levelAcess
            };
        }
    }
}
