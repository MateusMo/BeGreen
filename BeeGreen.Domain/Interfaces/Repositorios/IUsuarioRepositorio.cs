using BeGreen.Domain.Entidades;

namespace BeGreen.Domain.Interfaces.Repositorios
{
    public interface IUsuarioRepositorio : IRepositorioGenerico<Usuario>
    {
        Usuario ObterEmail(string email);
    }
}
