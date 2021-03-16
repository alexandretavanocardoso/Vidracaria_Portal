using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Vidracaria_Portal.Models.Selects;

namespace Vidracaria_Portal.Models.Administrador.Cadastros
{
    [Table("PRODUTOS")]
    public class ProdutosModel
    {
        [Key]
        public decimal Codigo { get; set; }

        [Display(Name = "Produto ", Prompt = "Nome do Produto")]
        [Required(ErrorMessage = "Por favor, informe o Nome do Produto")]
        [StringLength(100, ErrorMessage = "O Nome deve possuir no máximo 70 caracteres")]
        public string Nome { get; set; }

        [Display(Name = "Cor", Prompt = "Cor")]
        [Required(ErrorMessage = "Por favor, informe a Cor do Produto")]
        public int CorId { get; set; }
        public CoresModel Cor { get; set; }

        [Display(Name = "Marca (opcional)", Prompt = "Marca do Vidro")]
        [StringLength(100, ErrorMessage = "O Nome deve possuir no máximo 50 caracteres")]
        public string Marca { get; set; }

        [Display(Name = "Estoque Máximo ", Prompt = "Estoque Máximo")]
        [Required(ErrorMessage = "Por favor, informe o Estoque Máximo!")]
        public int EstoqueMaximo { get; set; }

        [Display(Name = "Estoque Mínimo ", Prompt = "Estoque Mínimo")]
        [Required(ErrorMessage = "Por favor, informe o Estoque Mínimo!")]
        public int EstoqueMinimo { get; set; }

        [Display(Name = "Valor da Venda ", Prompt = "Valor de Venda")]
        [Required(ErrorMessage = "Por favor, informe o preço de venda!")]
        public string PrecoVenda { get; set; }

        [Display(Name = "Valor da Fábrica ", Prompt = "Valor de Fabrica")]
        [Required(ErrorMessage = "Por favor, informe o preço de fábrica!")]
        public string PrecoFabrica { get; set; }

        [Display(Name = "Imagem (opcional)", Prompt = "Imagem")]
        [StringLength(300, ErrorMessage = "Imagem com erro")]
        public string Imagem { get; set; }

        [Display(Name = "Data do Cadastro")]
        public DateTime DataCadastro { get; set; }
    }
}
