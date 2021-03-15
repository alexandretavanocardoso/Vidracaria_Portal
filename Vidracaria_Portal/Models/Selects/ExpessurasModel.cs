using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Vidracaria_Portal.Models.Selects
{
    [Table("EXPESSURA")]
    public class ExpessurasModel
    {
        [Key]
        public int CodigoExpessura { get; set; }
        public int Expessura { get; set; }
    }
}
