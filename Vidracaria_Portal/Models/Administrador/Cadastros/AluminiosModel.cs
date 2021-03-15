using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Vidracaria_Portal.Models.Selects;

namespace Vidracaria_Portal.Models.Administrador.Cadastros
{
    [Table("ALUMINIOS")]
    public class AluminiosModel
    {
        [Key]
        public decimal CodigoAluminio { get; set; }

        [Display(Name = "Alumínio", Prompt = "Alumínio")]
        [Required(ErrorMessage = "Por favor, informe o Nome do Alumínio")]
        [StringLength(100, ErrorMessage = "O Nome deve possuir no máximo 70 caracteres")]
        public string NomeAluminio { get; set; }

        [Display(Name = "Cor", Prompt = "Cor")]
        [Required(ErrorMessage = "Por favor, informe a Cor")]
        public int CorId { get; set; }
        public CoresModel Cor { get; set; }

        [Display(Name = "Expessura", Prompt = "Expessura")]
        public int ExpessuraId { get; set; }
        public ExpessurasModel Expessura { get; set; }

        [Display(Name = "Marca do Alumínio ", Prompt = "Marca do Alumínio")]
        [StringLength(100, ErrorMessage = "O Nome deve possuir no máximo 50 caracteres")]
        public string Marca { get; set; }

        [Display(Name = "Estoque Máximo ", Prompt = "Máximo")]
        [Required(ErrorMessage = "Por favor, informe o Estoque Máximo!")]
        public int EstoqueMaximo { get; set; }

        [Display(Name = "Estoque Mínimo ", Prompt = "Mínimo")]
        [Required(ErrorMessage = "Por favor, informe o Estoque Mínimo!")]
        public int EstoqueMinimo { get; set; }

        [Display(Name = "Valor da Venda ", Prompt = "Venda")]
        [Required(ErrorMessage = "Por favor, informe a Expessura do Vidro!")]
        public decimal PrecoVenda { get; set; }

        [Display(Name = "Valor da Fábrica ", Prompt = "Fabrica")]
        [Required(ErrorMessage = "Por favor, informe a Expessura do Vidro!")]
        public decimal PrecoFabrica { get; set; }

        [Display(Name = "Estoque Máximo ", Prompt = "Máximo")]
        [StringLength(300, ErrorMessage = "Imagem com erro")]
        public string Imagem { get; set; }

        [Display(Name = "Data do Cadastro")]
        public DateTime DataCadastro { get; set; }
    }
}
