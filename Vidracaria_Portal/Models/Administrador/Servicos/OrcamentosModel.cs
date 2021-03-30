using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Vidracaria_Portal.Models.Administrador.Cadastros;
using Vidracaria_Portal.Models.Selects;

namespace Vidracaria_Portal.Models.Administrador.Servicos
{
    [Table("ORCAMENTOS")]
    public class OrcamentosModel
    {
        [Key]
        public int CodigoOrcamento { get; set; }

        [Display(Name = "Nome ", Prompt = "Nome")]
        [StringLength(70, ErrorMessage = "O Nome deve possuir no máximo 70 caracteres")]
        public string Nome { get; set; }


        [Display(Name = "Rua ", Prompt = "Rua")]       
        [StringLength(80, ErrorMessage = "A Cidade deve possuir no máximo 80 caracteres")]
        public string Rua { get; set; }

        [Display(Name = "Número da casa ", Prompt = "Numero")]  
        public int NumeroCasa { get; set; }

        [Display(Name = "Cidade ", Prompt = "Cidade")]
        [StringLength(80, ErrorMessage = "A Cidade deve possuir no máximo 80 caracteres")]
        public string Cidade { get; set; }

        [Display(Name = "Bairro ", Prompt = "Bairro")]
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
        public int TipoId { get; set; }
        public TipoDeServicosModel TipoServico { get; set; }

        [Display(Name = "Data do Cadastro")]
        public DateTime DataCadastro { get; set; }

        [Display(Name = "Imagem", Prompt = "Imagem")]
        public string Imagem { get; set; }

        [Display(Name = "Valor ", Prompt = "Valor")]
        public string Valor { get; set; }
    }
}
