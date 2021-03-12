﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Vidracaria_Portal.Models.Administrador.Cadastros
{
    [Table("VIDROS_COMUNS")]
    public class VidrosComunsModel
    {
        [Key]
        public int CodigoVidro { get; set; }

        [Display(Name = "Vidro: ", Prompt = "Vidro")]
        [Required(ErrorMessage = "Por favor, informe o Nome do Vidro")]
        [StringLength(70, ErrorMessage = "O Nome deve possuir no máximo 70 caracteres")]
        public string NomeVidro { get; set; }

        [Display(Name = "Cor do Vidro: ", Prompt = "Cor do Vidro")]
        [Required(ErrorMessage = "Por favor, informe a Cor do Vidro")]
        [StringLength(70, ErrorMessage = "O Nome deve possuir no máximo 50 caracteres")]
        public string CorVidro { get; set; }

        [Display(Name = "Marca da Vidro: ", Prompt = "Marca do Vidro")]
        [Required(ErrorMessage = "Por favor, informe a Marca do Vidro")]
        [StringLength(70, ErrorMessage = "O Nome deve possuir no máximo 50 caracteres")]
        public string Marca { get; set; }

        [Display(Name = "Estoque Máximo: ", Prompt = "Máximo")]
        [Required(ErrorMessage = "Por favor, informe o Estoque Máximo!")]
        public decimal EstoqueMaximo { get; set; }

        [Display(Name = "Estoque Mínimo: ", Prompt = "Mínimo")]
        [Required(ErrorMessage = "Por favor, informe o Estoque Mínimo!")]
        public decimal EstoqueMinimo { get; set; }

        [Display(Name = "Expessura do Vidro: ", Prompt = "Expessura")]
        [Required(ErrorMessage = "Por favor, informe a Expessura do Vidro!")]
        public int Expessura { get; set; }

        [Display(Name = "Valor da Venda: ", Prompt = "Venda")]
        [Required(ErrorMessage = "Por favor, informe a Expessura do Vidro!")]
        public int PrecoVenda { get; set; }

        [Display(Name = "Valor da Fábrica: ", Prompt = "Fabrica")]
        [Required(ErrorMessage = "Por favor, informe a Expessura do Vidro!")]
        public int PrecoFabrica { get; set; }
    }
}
