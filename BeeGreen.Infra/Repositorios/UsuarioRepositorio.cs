using BeGreen.Domain.Entidades;
using BeGreen.Domain.Interfaces.Repositorios;
using BeGreen.Infra.Contexto;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace BeGreen.Repositorios
{
    public class UsuarioRepositorio : RepositorioBase<Usuario>, IUsuarioRepositorio
    {
        private readonly DbSet<Usuario> _usuario;

        public UsuarioRepositorio(ContextBase db) : base(db)
        {
            _usuario = db.Set<Usuario>();
        }

        public Usuario ObterEmail(string email)
        {
            return _usuario
                .AsNoTracking()
                .FirstOrDefault(x => x.Email == email);
        }

    }
}
