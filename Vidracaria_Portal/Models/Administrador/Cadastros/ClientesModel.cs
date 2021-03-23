using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vidracaria_Portal.Models.Administrador.Cadastros
{
    [Table("CLIENTES")]
    public class ClientesModel
    {
        [Key]
        public int CodigoCliente { get; set; }

        [Display(Name = "Nome ", Prompt = "Nome do Cliente")]
        [Required(ErrorMessage = "Campo Obrigatório!")]
        [StringLength(70, ErrorMessage = "O Nome deve possuir no máximo 70 caracteres")]
        public string NomeCliente { get; set; }

        [Display(Name = "E-mail (opcional)", Prompt = "E-mail")]
        [EmailAddress(ErrorMessage = "Por favor, Informe um E-mail Válido!!")]
        public string Email { get; set; }

        [Display(Name = "Cidade ", Prompt = "Informe uma Cidade")]
        [Required(ErrorMessage = "Campo Obrigatório!")]
        [StringLength(80, ErrorMessage = "A Cidade deve possuir no máximo 80 caracteres")]
        public string CidadeCliente { get; set; }

        [Display(Name = "Bairro ", Prompt = "Infome um Bairro")]
        [Required(ErrorMessage = "Campo Obrigatório!")]
        [StringLength(80, ErrorMessage = "O Bairro deve possuir no máximo 80 caracteres")]
        public string Bairro { get; set; }

        [Display(Name = "Número da casa ", Prompt = "Informe o Numero da Casa")]
        [Required(ErrorMessage = "Campo Obrigatório!")]
        public int NumeroCasa { get; set; }

        [Display(Name = "Estado ", Prompt = "Informe um Estado")]
        [Required(ErrorMessage = "Campo Obrigatório!")]
        [StringLength(80, ErrorMessage = "O Estado deve possuir no máximo 80 caracteres")]
        public string EstadoCliente { get; set; }

        [Display(Name = "Celular ", Prompt = "Informe um Número de Celular")]
        [Required(ErrorMessage = "Campo Obrigatório!")]
        [StringLength(20, ErrorMessage = "O Celular deve possuir no máximo 20 caracteres")]
        public string Celular { get; set; }

        [Display(Name = "Documento (opcional)", Prompt = "Informe um Documento")]
        [StringLength(20, ErrorMessage = "O Documento deve possuir no máximo 20 caracteres")]
        public string Documento { get; set; }

        [Display(Name = "Data do Cadastro")]
        [Required(ErrorMessage = "Campo Obrigatório!")]
        public DateTime DataCadastro { get; set; }
    }
}
