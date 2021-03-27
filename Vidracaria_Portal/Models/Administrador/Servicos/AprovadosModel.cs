using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Vidracaria_Portal.Models.Selects;

namespace Vidracaria_Portal.Models.Administrador.Servicos
{
    [Table("APROVADOS")]
    public class AprovadosModel
    {
        [Key]
        public int CodigoAprovado { get; set; }
        public int CodigoOrcamento { get; set; }

        [Display(Name = "Nome ", Prompt = "Nome")]
        [Required(ErrorMessage = "Campo Obrigatório!")]
        [StringLength(70, ErrorMessage = "O Nome deve possuir no máximo 70 caracteres")]
        public string Nome { get; set; }


        [Display(Name = "Rua ", Prompt = "Rua")]
        [Required(ErrorMessage = "Campo Obrigatório!")]
        [StringLength(80, ErrorMessage = "A Cidade deve possuir no máximo 80 caracteres")]
        public string Rua { get; set; }

        [Display(Name = "Número da casa ", Prompt = "Numero")]
        [Required(ErrorMessage = "Campo Obrigatório!")]
        public int NumeroCasa { get; set; }

        [Display(Name = "Cidade ", Prompt = "Cidade")]
        [Required(ErrorMessage = "Campo Obrigatório!")]
        [StringLength(80, ErrorMessage = "A Cidade deve possuir no máximo 80 caracteres")]
        public string Cidade { get; set; }

        [Display(Name = "Bairro ", Prompt = "Bairro")]
        [Required(ErrorMessage = "Campo Obrigatório!")]
        [StringLength(80, ErrorMessage = "O Bairro deve possuir no máximo 80 caracteres")]
        public string Bairro { get; set; }

        [Display(Name = "Celular ", Prompt = "Celular")]
        [StringLength(20, ErrorMessage = "O Celular deve possuir no máximo 20 caracteres")]
        public string Celular { get; set; }

        [Display(Name = "Telefone ", Prompt = "Telefone")]
        [StringLength(20, ErrorMessage = "O Celular deve possuir no máximo 20 caracteres")]
        public string Telefone { get; set; }


        [Display(Name = "Estado ", Prompt = "Estado")]
        [StringLength(80, ErrorMessage = "O Estado deve possuir no máximo 80 caracteres")]
        public string Estado { get; set; }

        [Display(Name = "Tipo de Serviço ", Prompt = "Tipo")]
        [Required(ErrorMessage = "Campo Obrigatório!")]
        public int TipoId { get; set; }
        public TipoDeServicosModel TipoServico { get; set; }

        [Display(Name = "Data do Cadastro")]
        [Required(ErrorMessage = "Campo Obrigatório!")]
        public DateTime DataCadastro { get; set; }

        [Display(Name = "Imagem", Prompt = "Imagem")]
        [StringLength(300, ErrorMessage = "Imagem com erro")]
        public string Imagem { get; set; }
    }
}
