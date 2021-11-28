using System;
using System.ComponentModel.DataAnnotations;

namespace BeGreen.Dtos.Oferta
{
    public class UpdateOfertaDto
    {
        [Required(ErrorMessage = "O campo id é obrigatório")]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo título é obrigatório")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "O campo descrição é obrigatório")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "O campo data final é obrigatório")]
        public DateTime DataFinal { get; set; }

        [Required(ErrorMessage = "O campo latitude é obrigatório")]
        public double Latitude { get; set; }

        [Required(ErrorMessage = "O campo longitude é obrigatório")]
        public double Longitude { get; set; }

        [Required(ErrorMessage = "O campo código parceiro é obrigatório")]
        public int CodigoParceiro { get; set; }
    }
}
