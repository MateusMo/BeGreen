using BeGreen.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeGreen.Models
{
    public class Usuario
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        public string Senha { get; set; }

        public string Cpf { get; set; }

        public EGenero Genero  { get; set; }

        public DateTime DataNascimento { get; set; }

        public ETipoCadastro TipoCadastro { get; set; }

        public string Role { get; set; }
    }
}
