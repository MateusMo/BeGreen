using BeGreen.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace BeGreen.Dtos.Usuario
{
    public class ReadUsuarioDto
    {
        [Required(ErrorMessage = "O campo nome é obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo email é obrigatório")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O campo senha é obrigatório")]
        public string Senha { get; set; }

        [Required(ErrorMessage = "O campo CPF é obrigatório")]
        public string Cpf { get; set; }

        [Required(ErrorMessage = "O campo genêro é obrigatório")]
        public EGenero Genero { get; set; }

        [Required(ErrorMessage = "O campo data de nascimento é obrigatório")]
        public DateTime DataNascimento { get; set; }
    }
}
