using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Vidracaria_Portal.Models.Administrador.Cadastros
{
    [Table("NOSSO_TIME")]
    public class TimeModel
    {
        [Key]
        public int CodigoTIme { get; set; }
        public string NomeTime { get; set; }
        public string Cargo { get; set; }
        public string Imagem { get; set; }
        public string LinkFacebook { get; set; }
        public string LinkImagem { get; set; }
    }
}
