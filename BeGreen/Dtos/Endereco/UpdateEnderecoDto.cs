using BeGreen.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BeGreen.Dtos.EnderecoDto
{
    public class UpdateEnderecoDto
    {
        [Required(ErrorMessage = "O campo CEP é obrigatório")]
        public string Cep { get; set; }

        [Required(ErrorMessage = "O campo Logradouro é obrigatório")]
        public string Logradouro { get; set; }

        [Required(ErrorMessage = "O campo número é obrigatório")]
        public int Numero { get; set; }

        public string Complemento { get; set; }
    }
}
