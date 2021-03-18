using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Vidracaria_Portal.ViewModel
{
    public class LoginViewModel
    {
        [Display(Name = "E-mail de Acesso", Prompt = "E-mail de acesso")]
        [Required(ErrorMessage = "Por favor, informe o e-mail de acesso")]
        [EmailAddress(ErrorMessage = "Por favor, informe o e-mail de acesso")] // Tipo email    
        public string Email { get; set; }

        [Display(Name = "Senha de Acesso", Prompt = "Senha de acesso")]
        [Required(ErrorMessage = "Por favor, informe o Senha de acesso")]
        [DataType(DataType.Password)] // Tipo senha    
        public string Senha { get; set; }

        [Display(Name = "Continuar conectado?")]
        public bool Manter { get; set; }
    }
}
