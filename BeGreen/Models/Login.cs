using BeGreen.Enums;

namespace BeGreen.Models
{
    public class Login
    {
        public int Id { get; set; }

        public string Email { get; set; }

        public string Senha { get; set; }

        public Parceiro Parceiro { get; set; }

        public Usuario Usuario { get; set; }

        public ETipoCadastro TipoCadastro { get; set; }
    }
}
