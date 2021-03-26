using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Vidracaria_Portal.Models.Administrador.Cadastros
{
    [Table("GALERIA")]
    public class GaleriaModel
    {
        [Key]
        public int CodigoGaleria { get; set; }
        public string Imagem { get; set; }
    }
}
