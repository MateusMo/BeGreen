using BeGreen.Domain.Entidades;

namespace BeGreen.Domain.Interfaces.Repositorios
{
    public interface ILoginRepositorio : IRepositorioGenerico<Login>
    {
        Login Login(string email, string senha);
    }
}
