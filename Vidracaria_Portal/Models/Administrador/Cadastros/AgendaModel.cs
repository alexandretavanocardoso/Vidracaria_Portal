using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Vidracaria_Portal.Models.Administrador.Cadastros
{
    [Table("AGENDA")]
    public class AgendaModel
    {
        [Key]
        public int CodigoAgenda { get; set; }
        
        [Required(ErrorMessage = "Campo Obrigatório!")]
        public string Texto { get; set; }
        public string Assunto { get; set; }
        public DateTime? DataCadastro { get; set; }
        public DateTime? DataLimite { get; set; }
    }
}
