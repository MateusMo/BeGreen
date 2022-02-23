using BeGreen.Domain.Entidades;
using BeGreen.Domain.Interfaces.Repositorios;
using BeGreen.Infra.Contexto;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace BeGreen.Repositorios
{
    public class ParceiroRepositorio : RepositorioBase<Parceiro>, IParceiroRepositorio
    {
        private readonly DbSet<Parceiro> _parceiro;

        public ParceiroRepositorio(ContextBase db) : base(db)
        {
            _parceiro = db.Set<Parceiro>();
        }

        public Parceiro ObterEmail(string email)
        {
            return _parceiro
                .Include(x => x.Login)
                .AsNoTracking()
                .FirstOrDefault(x => x.Email == email);
        }

    }
}
