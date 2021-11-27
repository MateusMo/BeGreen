using BeGreen.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BeGreen.Models
{
    [Table("Endereco")]
    public class Endereco
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "CEP obrigatório.")]
        public string Cep { get; set; }

        [Required(ErrorMessage = "Lagradouro obrigatório.")]
        public string Lagradouro { get; set; }

        [Required(ErrorMessage = "Numero obrigatório.")]
        public int Numero { get; set; }

        [Required(ErrorMessage = "Complemento obrigatório.")]
        public string Complemento { get; set; }

        public Parceiro Parceiro { get; set; }
    }
}
