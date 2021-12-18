using BeGreen.Domain.Enums;
using System.Collections.Generic;

namespace BeGreen.Domain.Entidades
{
    public class Parceiro
    {
        public Parceiro()
        {
            Ofertas = new List<Oferta>();
        }

        public int Id { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        public string Senha { get; set; }

        public string Cnpj { get; set; }

        public string Ramo { get; set; }

        public string Cep { get; set; }

        public string Logradouro { get; set; }

        public int Numero { get; set; }

        public string Complemento { get; set; }

        public ETipoCadastro TipoCadastro { get; set; }

        public int CodigoLogin { get; set; }

        public Login Login { get; set; }

        public List<Oferta> Ofertas { get; set; }
    }
}
