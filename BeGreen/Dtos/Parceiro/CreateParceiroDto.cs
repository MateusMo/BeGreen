using BeGreen.Enums;
using BeGreen.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BeGreen.Dtos.ParceiroDto
{
    public class CreateParceiroDto
    {
        [Required(ErrorMessage = "O campo nome é obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo email é obrigatório")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O campo senha é obrigatório")]
        public string Senha { get; set; }

        [Required(ErrorMessage = "O campo CNPJ é obrigatório")]
        public string Cnpj { get; set; }

        [Required(ErrorMessage = "O campo ramo é obrigatório")]
        public string Ramo { get; set; }
    }
}
