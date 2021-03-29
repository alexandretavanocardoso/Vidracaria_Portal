using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Vidracaria_Portal.Models.Administrador.Cadastros
{
    [Table("SERVICOS")]
    public class ServicosModel
    {
        [Key]
        public int CodigoServico { get; set; }
        public string NomeServico { get; set; }
        public string Imagem { get; set; }
    }
}
