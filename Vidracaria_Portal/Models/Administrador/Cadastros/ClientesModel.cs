using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vidracaria_Portal.Models.Administrador.Cadastros
{
    [Table("CLIENTES")]
    public class ClientesModel
    {
        [Key]
        public decimal CodigoCliente { get; set; }

        [Display(Name = "Nome ", Prompt = "Nome do Cliente")]
        [Required(ErrorMessage = "Por favor, informe o Nome do Cliente")]
        [StringLength(70, ErrorMessage = "O Nome deve possuir no máximo 70 caracteres")]
        public string NomeCliente { get; set; }

        [Display(Name = "E-mail (opcional)", Prompt = "E-mail")]
        [EmailAddress(ErrorMessage = "Por favor, Informe um E-mail Válido!!")]
        public string Email { get; set; }

        [Display(Name = "Cidade ", Prompt = "Informe uma Cidade")]
        [Required(ErrorMessage = "Por favor, informe a Cidade")]
        [StringLength(80, ErrorMessage = "A Cidade deve possuir no máximo 80 caracteres")]
        public string CidadeCliente { get; set; }

        [Display(Name = "Bairro ", Prompt = "Infome um Bairro")]
        [Required(ErrorMessage = "Por favor, informe o Bairro")]
        [StringLength(80, ErrorMessage = "O Bairro deve possuir no máximo 80 caracteres")]
        public string Bairro { get; set; }

        [Display(Name = "Número da casa ", Prompt = "Informe o Numero da Casa")]
        [Required(ErrorMessage = "Por favor, informe o numero da casa")]
        public int NumeroCasa { get; set; }

        [Display(Name = "Estado ", Prompt = "Informe um Estado")]
        [Required(ErrorMessage = "Por favor, informe o Estado")]
        [StringLength(80, ErrorMessage = "O Estado deve possuir no máximo 80 caracteres")]
        public string EstadoCliente { get; set; }

        [Display(Name = "Celular ", Prompt = "Informe um Número de Celular")]
        [Required(ErrorMessage = "Por favor, informe o Celular")]
        [StringLength(20, ErrorMessage = "O Celular deve possuir no máximo 20 caracteres")]
        public string Celular { get; set; }

        [Display(Name = "Documento (opcional)", Prompt = "Informe um Documento")]
        [StringLength(20, ErrorMessage = "O Documento deve possuir no máximo 20 caracteres")]
        public string Documento { get; set; }

        [Display(Name = "Data do Cadastro")]
        public DateTime DataCadastro { get; set; }
    }
}
