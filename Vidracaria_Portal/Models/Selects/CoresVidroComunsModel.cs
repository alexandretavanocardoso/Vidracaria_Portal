using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Vidracaria_Portal.Models.Selects
{
    [Table("CORES_VIDROS_COMUNS")]
    public class CoresVidroComunsModel
    {
        [Key]
        public int CodigoCor { get; set; }
        public string NomeCor { get; set; }
    }
}
