using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Vidracaria_Portal.Models.Selects
{
    [Table("CARGOS")]
    public class CargosModel
    {
        [Key]
        public int CodigoCargo { get; set; }
        public string NomeCargo { get; set; }
    }
}
