using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Vidracaria_Portal.Models.Selects;

namespace Vidracaria_Portal.Models.Administrador.Cadastros
{
    [Table("VIDROS_COMUNS")]
    public class VidrosComunsModel
    {
        [Key]
        public decimal CodigoVidro { get; set; }

        [Display(Name = "Vidro ", Prompt = "Vidro")]
        [Required(ErrorMessage = "Por favor, informe o Nome do Vidro")]
        [StringLength(70, ErrorMessage = "O Nome deve possuir no máximo 70 caracteres")]
        public string NomeVidro { get; set; }

        [Display(Name = "Cor", Prompt = "Cor")]
        [Required(ErrorMessage = "Por favor, informe a Cor")]
        public int AdesivoId { get; set; }
        public AdesivoModel Adesivo { get; set; }

        [Display(Name = "Cor", Prompt = "Cor")]
        [Required(ErrorMessage = "Por favor, informe a Cor")]
        public int PeliculaId { get; set; }
        public PeliculasModel Pelicula { get; set; }

        [Display(Name = "Cor", Prompt = "Cor")]
        [Required(ErrorMessage = "Por favor, informe a Cor")]
        public int CorId { get; set; }
        public CoresVidroComunsModel Cor { get; set; }

        [Display(Name = "Expessura", Prompt = "Expessura")]
        public int ExpessuraId { get; set; }
        public ExpessurasModel Expessura { get; set; }

        [Display(Name = "Marca da Vidro ", Prompt = "Marca do Vidro")]
        [StringLength(70, ErrorMessage = "O Nome deve possuir no máximo 50 caracteres")]
        public string Marca { get; set; }

        [Display(Name = "Estoque Máximo ", Prompt = "Máximo")]
        [Required(ErrorMessage = "Por favor, informe o Estoque Máximo!")]
        public decimal EstoqueMaximo { get; set; }

        [Display(Name = "Estoque Mínimo ", Prompt = "Mínimo")]
        [Required(ErrorMessage = "Por favor, informe o Estoque Mínimo!")]
        public decimal EstoqueMinimo { get; set; }

        [Display(Name = "Valor da Venda ", Prompt = "Venda")]
        [Required(ErrorMessage = "Por favor, informe a Expessura do Vidro!")]
        public int PrecoVenda { get; set; }

        [Display(Name = "Valor da Fábrica ", Prompt = "Fabrica")]
        [Required(ErrorMessage = "Por favor, informe a Expessura do Vidro!")]
        public int PrecoFabrica { get; set; }

        [Display(Name = "Estoque Máximo ", Prompt = "Máximo")]
        [StringLength(300, ErrorMessage = "Imagem com erro")]
        public string Imagem { get; set; }

        [Display(Name = "Data do Cadastro")]
        public DateTime DataCadastro { get; set; }
    }
}
