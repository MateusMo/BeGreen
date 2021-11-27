using BeGreen.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BeGreen.Models
{
    [Table("Parceiro")]
    public class Parceiro
    {
        public Parceiro()
        {
            Enderecos = new List<Endereco>();
        }

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

        [StringLength(14, ErrorMessage = "CNPJ inválido")]
        public string Cnpj { get; set; }

        [MaxLength(50, ErrorMessage = "Ramo inválido")]
        public string Ramo { get; set; }

        public List<Endereco> Enderecos { get; set; }

        public ETipoCadastro TipoCadastro { get; set; }

        public Login Login { get; set; }
    }
}
