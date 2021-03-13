using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Vidracaria_Portal.Models.Administrador.Cadastros;

namespace Vidracaria_Portal.Models.Administrador.Servicos
{
    [Table("PENDENTES")]
    public class PendentesModel
    {
        [Key]
        public decimal CodigoPendentes { get; set; }

        [Display(Name = "Nome: ", Prompt = "Nome")]
        [Required(ErrorMessage = "Por favor, informe o Nome")]
        [StringLength(70, ErrorMessage = "O Nome deve possuir no máximo 70 caracteres")]
        public string Nome { get; set; }

        [Display(Name = "Data do Cadastro")]
        public DateTime DataCadastro { get; set; }

        [Display(Name = "Cidade: ", Prompt = "Cidade")]
        [Required(ErrorMessage = "Por favor, informe a Cidade")]
        [StringLength(80, ErrorMessage = "A Cidade deve possuir no máximo 80 caracteres")]
        public string Cidade { get; set; }

        [Display(Name = "Bairro: ", Prompt = "Bairro")]
        [Required(ErrorMessage = "Por favor, informe o Bairro")]
        [StringLength(80, ErrorMessage = "O Bairro deve possuir no máximo 80 caracteres")]
        public string Bairro { get; set; }

        [Display(Name = "Número da casa: ", Prompt = "Numero")]
        [Required(ErrorMessage = "Por favor, informe o numero da cada")]
        public int NumeroCasa { get; set; }

        [Display(Name = "Estado: ", Prompt = "Estado")]
        [StringLength(80, ErrorMessage = "O Estado deve possuir no máximo 80 caracteres")]
        public string Estado { get; set; }

        [Display(Name = "Celular: ", Prompt = "Celular")]
        [Required(ErrorMessage = "Por favor, informe o Celular")]
        [StringLength(20, ErrorMessage = "O Celular deve possuir no máximo 20 caracteres")]
        public string Celular { get; set; }

        [Display(Name = "Estoque Máximo: ", Prompt = "Máximo")]
        [Required(ErrorMessage = "Por favor, informe o Estoque Máximo!")]
        [StringLength(300, ErrorMessage = "Imagem com erro")]
        public string Imagem { get; set; }
    }
}
