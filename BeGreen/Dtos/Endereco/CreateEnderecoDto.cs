using BeGreen.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BeGreen.Dtos.EnderecoDto
{
    public class CreateEnderecoDto
    {
        [Required(ErrorMessage = "O campo CEP é obrigatório")]
        public string Cep { get; set; }

        [Required(ErrorMessage = "O campo lagradouro é obrigatório")]
        public string Lagradouro { get; set; }

        [Required(ErrorMessage = "O campo número é obrigatório")]
        public int Numero { get; set; }

        public string Complemento { get; set; }
    }
}
