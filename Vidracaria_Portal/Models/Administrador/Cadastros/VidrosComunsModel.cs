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

        [Display(Name = "Vidro ", Prompt = "Nome do Vidro")]
        [Required(ErrorMessage = "Campo Obrigatório!")]
        [StringLength(70, ErrorMessage = "O Nome deve possuir no máximo 70 caracteres")]
        public string NomeVidro { get; set; }

        [Display(Name = "Adesivo (opcional)", Prompt = "Informe o Adesivo")]
        public int AdesivoId { get; set; }
        public AdesivoModel Adesivo { get; set; }

        [Display(Name = "Pelicula (opcional)", Prompt = "Informe a Pelicula")]
        public int PeliculaId { get; set; }
        public PeliculasModel Pelicula { get; set; }

        [Display(Name = "Expessura (opcional)", Prompt = "Informe a Expessura")]
        [Required(ErrorMessage = "Campo Obrigatório!")]
        public int ExpessuraId { get; set; }
        public ExpessurasModel Expessura { get; set; }

        [Display(Name = "Marca da Vidro (opcional)", Prompt = "Marca do Vidro")]
        [StringLength(70, ErrorMessage = "O Nome deve possuir no máximo 50 caracteres")]
        public string Marca { get; set; }

        [Display(Name = "Estoque Máximo ", Prompt = "Estoque Máximo")]
        [Required(ErrorMessage = "Campo Obrigatório!")]
        public decimal EstoqueMaximo { get; set; }

        [Display(Name = "Estoque Mínimo ", Prompt = "Estoque Mínimo")]
        [Required(ErrorMessage = "Campo Obrigatório!")]
        public decimal EstoqueMinimo { get; set; }

        [Display(Name = "Valor da Venda ", Prompt = "Valor de Venda")]
        [Required(ErrorMessage = "Campo Obrigatório!")]
        public string PrecoVenda { get; set; }

        [Display(Name = "Valor da Fábrica ", Prompt = "Valor de Fábrica")]
        [Required(ErrorMessage = "Campo Obrigatório!")]
        public string PrecoFabrica { get; set; }

        [Display(Name = "Imagem (opcional)", Prompt = "Imagem")]
        [StringLength(300, ErrorMessage = "Imagem com erro")]
        public string Imagem { get; set; }

        [Display(Name = "Data do Cadastro")]
        public DateTime DataCadastro { get; set; }
    }
}
