using BeGreen.Enums;
using System.Collections.Generic;

namespace BeGreen.Models
{
    public class Parceiro
    {
        public Parceiro()
        {
            Enderecos = new List<Endereco>();
            Ofertas = new List<Oferta>();
        }

        public int Id { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        public string Senha { get; set; }

        public string Cnpj { get; set; }

        public string Ramo { get; set; }

        public ETipoCadastro TipoCadastro { get; set; }

        public int CodigoLogin { get; set; }

        public Login Login { get; set; }

        public List<Endereco> Enderecos { get; set; }

        public List<Oferta> Ofertas { get; set; }
    }
}
