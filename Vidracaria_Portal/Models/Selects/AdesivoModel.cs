using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Vidracaria_Portal.Models.Selects
{
    [Table("ADESIVOS")]
    public class AdesivoModel
    {
        [Key]
        public int CodigoAdesivo { get; set; }
        public string Nome { get; set; }
    }
}
