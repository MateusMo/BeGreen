using BeGreen.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeGreen.Models
{
    public class Oferta
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public Parceiro Empresa { get; set; }

    }
}
