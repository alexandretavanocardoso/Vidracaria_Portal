using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Vidracaria_Portal.Models.Selects;

namespace Vidracaria_Portal.Models.Administrador.Cadastros
{
    [Table("FERRAGENS")]
    public class FerragensModel
    {
        [Key]

        public decimal CodigoFerragem { get; set; }

        [Display(Name = "Ferragem ", Prompt = "Nome da Ferragem")]
        [Required(ErrorMessage = "Campo Obrigatório!")]
        [StringLength(70, ErrorMessage = "O Nome deve possuir no máximo 70 caracteres")]
        public string NomeFerragem { get; set; }

        [Display(Name = "Cor", Prompt = "Cor da Ferragem")]
        [Required(ErrorMessage = "Campo Obrigatório!")]
        public int CorId { get; set; }
        public CoresModel Cor { get; set; }

        [Display(Name = "Marca (opcional)", Prompt = "Marca")]
        [StringLength(70, ErrorMessage = "O Nome deve possuir no máximo 50 caracteres")]
        public string Marca { get; set; }

        [Display(Name = "Estoque Máximo ", Prompt = "Estoque Máximo")]
        [Required(ErrorMessage = "Campo Obrigatório!")]
        public int EstoqueMaximo { get; set; }

        [Display(Name = "Estoque Mínimo ", Prompt = "Estoque Mínimo")]
        [Required(ErrorMessage = "Campo Obrigatório!")]
        public int EstoqueMinimo { get; set; }

        [Display(Name = "Valor da Venda ", Prompt = "Valor de Venda")]
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
