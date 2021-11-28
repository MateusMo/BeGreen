namespace BeGreen.Models
{
    public class Endereco
    {
        public int Id { get; set; }

        public string Cep { get; set; }

        public string Logradouro { get; set; }

        public int Numero { get; set; }

        public string Complemento { get; set; }

        public Parceiro Parceiro { get; set; }
    }
}
