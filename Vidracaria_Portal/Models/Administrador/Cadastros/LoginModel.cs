using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Vidracaria_Portal.Models.Administrador.Cadastros
{
    [Table("LOGIN")]
    public class LoginModel
    {
        [Key]
        public decimal CodigoUsuario { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
    }
}
