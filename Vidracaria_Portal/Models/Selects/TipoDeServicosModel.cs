using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Vidracaria_Portal.Models.Selects
{
    [Table("TIPOS_DE_SERVICOS")]
    public class TipoDeServicosModel
    {
        [Key]
        public int CodigoTipo { get; set; }
        public string Tipo { get; set; }
    }
}
