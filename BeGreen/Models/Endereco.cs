using BeGreen.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeGreen.Models
{
    public class Endereco
    {
        public int Id { get; set; }

        public string Cep { get; set; }

        public string Lagradouro { get; set; }

        public int Numero { get; set; }

        public string Complemento { get; set; }
    }
}
