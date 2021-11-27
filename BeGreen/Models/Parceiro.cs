using BeGreen.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeGreen.Models
{
    public class Parceiro
    {
        public Parceiro()
        {
            Enderecos = new List<Endereco>();
        }

        public int Id { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        public string Senha { get; set; }

        public string Cnpj { get; set; }

        public string Ramo { get; set; }

        public ETipoCadastro TipoCadastro { get; set; }

        public List<Endereco> Enderecos { get; set; }
    }
}
