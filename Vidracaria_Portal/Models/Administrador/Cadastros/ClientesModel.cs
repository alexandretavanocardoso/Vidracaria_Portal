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

        [Display(Name = "Nome ", Prompt = "Nome")]
        [Required(ErrorMessage = "Por favor, informe o Nome do Cliente")]
        [StringLength(70, ErrorMessage = "O Nome deve possuir no máximo 70 caracteres")]
        public string NomeCliente { get; set; }

        [Display(Name = "E-mail", Prompt = "E-mail")]
        [Required(ErrorMessage = "Por favor, Informe o E-mail")]
        [EmailAddress(ErrorMessage = "Por favor, Informe um E-mail Válido!!")]
        public string Email { get; set; }

        [Display(Name = "Cidade ", Prompt = "Cidade")]
        [Required(ErrorMessage = "Por favor, informe a Cidade")]
        [StringLength(80, ErrorMessage = "A Cidade deve possuir no máximo 80 caracteres")]
        public string CidadeCliente { get; set; }

        [Display(Name = "Bairro ", Prompt = "Bairro")]
        [Required(ErrorMessage = "Por favor, informe o Bairro")]
        [StringLength(80, ErrorMessage = "O Bairro deve possuir no máximo 80 caracteres")]
        public string Bairro { get; set; }

        [Display(Name = "Número da casa ", Prompt = "Numero")]
        [Required(ErrorMessage = "Por favor, informe o numero da cada")]
        public int NumeroCasa { get; set; }

        [Display(Name = "Estado ", Prompt = "Estado")]
        [Required(ErrorMessage = "Por favor, informe o Estado")]
        [StringLength(80, ErrorMessage = "O Estado deve possuir no máximo 80 caracteres")]
        public string EstadoCliente { get; set; }

        [Display(Name = "Celular ", Prompt = "Celular")]
        [Required(ErrorMessage = "Por favor, informe o Celular")]
        [StringLength(20, ErrorMessage = "O Celular deve possuir no máximo 20 caracteres")]
        public string Celular { get; set; }
        [Display(Name = "Documento ", Prompt = "Documento")]
        [StringLength(20, ErrorMessage = "O Documento deve possuir no máximo 20 caracteres")]
        public string Documento { get; set; }

        [Display(Name = "Data do Cadastro")]
        public DateTime DataCadastro { get; set; }

        [Display(Name = "Estoque Máximo ", Prompt = "Máximo")]
        [Required(ErrorMessage = "Por favor, informe o Estoque Máximo!")]
        [StringLength(300, ErrorMessage = "Imagem com erro")]
        public string Imagem { get; set; }

    }
}
