using BeGreen.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BeGreen.Models
{
    [Table("Oferta")]
    public class Oferta
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "Nome obrigatório.")]
        public string Nome { get; set; }

        public Parceiro Parceiro { get; set; }
    }
}
