﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entitities.Entidades
{
    public class Empresas
    {
        [Key]
        [Display(Name = "IdEmpresa")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdEmpresa { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [Display(Name = "Código de acesso da empresa")]
        public string CodigoEmpresa { get; set; }
         
        [Display(Name = "Nome da empresa")]
        public string? Nome { get; set; }
         
        [Display(Name = "CNPJ")]
        public string? CNPJ { get; set; }
         
        [Display(Name = "Endereço")]
        public string? Endereco { get; set; }
         
        [Display(Name = "Número")]
        public int? Numero { get; set; }
         
        [Display(Name = "Bairro")]
        public string? Bairro { get; set; }
         
        [Display(Name = "Cidade")]
        public string? Cidade { get; set; }
         
        [Display(Name = "Estado")]
        public string? Estado { get; set; }
         
        [Display(Name = "CEP")]
        public string? CEP { get; set; }
         
        [Display(Name = "Telefone")]
        public string? Telefone { get; set; }
         
        [Display(Name = "E-mail")]
        public string? Email { get; set; }
         
        [Display(Name = "Nome do responsável")]
        public string? NomeResponsavel { get; set; }
         
        [Display(Name = "CPF do responsável")]
        public string? CPFResponsavel { get; set; }
         
        [Display(Name = "Telefone do responsável")]
        public string? TelefoneResponsavel { get; set; }
         
        [Display(Name = "E-mail do responsável")]
        public string? EmailResponsavel { get; set; }

        [Display(Name = "Número Máximo de Usuários")]
        public int? NumeroMaxUsuarios { get; set; }
    }
}
