using System;

namespace BeGreen.Models
{
    public class Oferta
    {
        public int Id { get; set; }

        public string Titulo { get; set; }

        public string Descricao { get; set; }

        public DateTime DataInicio { get; set; }

        public DateTime DataFinal { get; set; }

        public double Latitude { get; set; }

        public double Longitude { get; set; }

        public Parceiro Parceiro { get; set; }
    }
}
