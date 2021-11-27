using BeGreen.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BeGreen.Models
{
    public class Login
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public string Email { get; set; }

        public Parceiro Parceiro { get; set; }

        public Usuario Usuario { get; set; }

        public ETipoCadastro TipoCadastro { get; set; }
    }
}
