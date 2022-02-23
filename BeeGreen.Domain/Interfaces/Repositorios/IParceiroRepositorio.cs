using BeGreen.Domain.Entidades;

namespace BeGreen.Domain.Interfaces.Repositorios
{
    public interface IParceiroRepositorio : IRepositorioGenerico<Parceiro>
    {
        Parceiro ObterEmail(string email);
    }
}
