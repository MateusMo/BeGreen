using BeGreen.Enums;
using BeGreen.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BeGreen.Dtos.Oferta
{
    public class CreateOfertaDto
    {
        [Required(ErrorMessage = "O campo título é obrigatório")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "O campo descrição é obrigatório")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "O campo data de início é obrigatório")]
        public DateTime DataInicio { get; set; }

        [Required(ErrorMessage = "O campo data final é obrigatório")]
        public DateTime DataFinal { get; set; }

        [Required(ErrorMessage = "O campo latitude é obrigatório")]
        public double Latitude { get; set; }

        [Required(ErrorMessage = "O campo longitude é obrigatório")]
        public double Longitude { get; set; }
    }
}
