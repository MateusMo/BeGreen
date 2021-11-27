using BeGreen.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BeGreen.Models
{
    [Table("Usuario")]
    public class Usuario
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [MinLength(3, ErrorMessage = "Nome inválido")]
        [MaxLength(50, ErrorMessage = "Nome inválido")]
        [Required(ErrorMessage = "Nome obrigatório.")]
        public string Nome { get; set; }

        [MinLength(3, ErrorMessage = "Email inválido")]
        [MaxLength(50, ErrorMessage = "Email inválido")]
        [Required(ErrorMessage = "Email obrigatório.")]
        public string Email { get; set; }

        [MinLength(3, ErrorMessage = "Email inválido")]
        [MaxLength(50, ErrorMessage = "Email inválido")]
        [Required(ErrorMessage = "Email obrigatório.")]
        public string Senha { get; set; }

        [StringLength(11, ErrorMessage = "CPF inválido")]
        [Required(ErrorMessage = "Email obrigatório.")]
        public string Cpf { get; set; }

        public EGenero Genero  { get; set; }

        [Required(ErrorMessage = "Data de nascimento obrigatória.")]
        public DateTime DataNascimento { get; set; }
        
        public ETipoCadastro TipoCadastro { get; set; }

        public Login Login { get; set; }
    }
}
