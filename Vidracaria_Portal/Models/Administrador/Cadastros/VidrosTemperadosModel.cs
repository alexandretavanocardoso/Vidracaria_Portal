using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Vidracaria_Portal.Models.Selects;

namespace Vidracaria_Portal.Models.Administrador.Cadastros
{
    [Table("VIDROS_TEMPERADOS")]
    public class VidrosTemperadosModel
    {
        [Key]
        public decimal CodigoVidro { get; set; }

        [Display(Name = "Vidro", Prompt = "Nome do Vidro")]
        [Required(ErrorMessage = "Por favor, informe o Nome do Vidro")]
        [StringLength(70, ErrorMessage = "O Nome deve possuir no máximo 70 caracteres")]
        public string NomeVidro { get; set; }

        [Display(Name = "Adesivo (opcional)", Prompt = "Informe o Adesivo")]
        public int AdesivoId { get; set; }
        public AdesivoModel Adesivo { get; set; }

        [Display(Name = "Pelicula (opcional)", Prompt = "Informe a pelicula")]
        public int PeliculaId { get; set; }
        public PeliculasModel Pelicula { get; set; }

        [Display(Name = "Expessura", Prompt = "Expessura do Vidro")]
        [Required(ErrorMessage = "Campo Obrigatório!")]
        public int ExpessuraId { get; set; }
        public ExpessurasModel Expessura { get; set; }

        [Display(Name = "Marca do Vidro (opcional)", Prompt = "Marca do Vidro")]
        [StringLength(70, ErrorMessage = "O Nome deve possuir no máximo 50 caracteres")]
        public string Marca { get; set; }

        [Display(Name = "Estoque Máximo ", Prompt = "Estoque Máximo")]
        [Required(ErrorMessage = "Campo Obrigatório!")]
        public int EstoqueMaximo { get; set; }

        [Display(Name = "Estoque Mínimo ", Prompt = "Estoque Mínimo")]
        [Required(ErrorMessage = "Campo Obrigatório!")]
        public int EstoqueMinimo { get; set; }

        [Display(Name = "Valor da Venda ", Prompt = "Valo de Venda")]
        [Required(ErrorMessage = "Campo Obrigatório!")]
        public decimal PrecoVenda { get; set; }

        [Display(Name = "Valor da Fábrica ", Prompt = "Valor de Fábrica")]
        [Required(ErrorMessage = "Campo Obrigatório!")]
        public decimal PrecoFabrica { get; set; }

        [Display(Name = "Imagem (opcional)", Prompt = "Imagem")]
        [StringLength(300, ErrorMessage = "Imagem com erro")]
        public string Imagem { get; set; }

        [Display(Name = "Data do Cadastro")]
        [Required(ErrorMessage = "Campo Obrigatório!")]
        public DateTime DataCadastro { get; set; }
    }
}
