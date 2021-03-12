using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Vidracaria_Portal.Models
{
    public class UsuarioModel : IdentityUser
    {
        [Display(Name = "Nome Completo")]
        [Required(ErrorMessage = "Informe seu nome completo")]
        [StringLength(50, ErrorMessage = "Maximo 50 caracteres")]
        public string Nome { get; set; }

        [Display(Name = "Data Nascimento")]
        [DataType(DataType.Date)] // Campo de data
        public DateTime DataNascimento { get; set; }

        [NotMapped] // Essa propriedade nao vai existir no banco
        public string Roles { get; set; } // pode ou nao acessar determinada pagina
    }
}
