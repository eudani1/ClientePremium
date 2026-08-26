using System;
using System.ComponentModel.DataAnnotations;

namespace ClientePremium.Models
{
    public class ClientePremiumViewModel
    {
        [Required(ErrorMessage = "O nome completo é obrigatório.")]
        [StringLength(100, MinimumLength = 5,
            ErrorMessage = "O nome completo deve ter entre 5 e 100 caracteres.")]
        [Display(Name = "Nome Completo")]
        public string NomeCompleto { get; set; }

        [Required(ErrorMessage = "A data de nascimento é obrigatória.")]
        [DataType(DataType.Date)]
        [Display(Name = "Data de Nascimento")]
        public DateTime DataNascimento { get; set; }

        [Required(ErrorMessage = "O CPF é obrigatório.")]
        [RegularExpression(@"^\d{3}\.\d{3}\.\d{3}-\d{2}$",
            ErrorMessage = "O CPF deve estar no formato 000.000.000-00.")]
        [Display(Name = "CPF")]
        public string Cpf { get; set; }

        [Required(ErrorMessage = "O telefone celular é obrigatório.")]
        [Phone(ErrorMessage = "Informe um número de telefone celular válido.")]
        [Display(Name = "Telefone Celular")]
        public string TelefoneCelular { get; set; }

        [Url(ErrorMessage = "Informe uma URL válida para o perfil do LinkedIn.")]
        [Display(Name = "URL do Perfil LinkedIn")]
        public string UrlPerfilLinkedIn { get; set; }

        [Required(ErrorMessage = "A renda mensal é obrigatória.")]
        [Range(3000.00, 1000000.00,
            ErrorMessage = "A renda mensal deve estar entre R$ 3.000,00 e R$ 1.000.000,00.")]
        [DataType(DataType.Currency)]
        [Display(Name = "Renda Mensal")]
        public decimal RendaMensal { get; set; }

        [Required(ErrorMessage = "O número do cartão de crédito é obrigatório.")]
        [CreditCard(ErrorMessage = "Informe um número de cartão de crédito válido.")]
        [Display(Name = "Número do Cartão de Crédito")]
        public string NumeroCartaoCredito { get; set; }

        [Required(ErrorMessage = "A senha de acesso é obrigatória.")]
        [DataType(DataType.Password)]
        [RegularExpression(
            @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^a-zA-Z\d]).{8,}$",
            ErrorMessage = "A senha deve conter no mínimo 8 caracteres, uma letra maiúscula, uma letra minúscula, um número e um caractere especial.")]
        [Display(Name = "Senha de Acesso")]
        public string SenhaAcesso { get; set; }

        [Required(ErrorMessage = "A confirmação da senha é obrigatória.")]
        [DataType(DataType.Password)]
        [Compare(nameof(SenhaAcesso),
            ErrorMessage = "A confirmação da senha deve ser igual à senha de acesso.")]
        [Display(Name = "Confirmar Senha de Acesso")]
        public string ConfirmarSenhaAcesso { get; set; }
    }
}