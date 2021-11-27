using BeGreen.Context;
using BeGreen.InterfaceRepositorio;
using BeGreen.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeGreen.Repositorios
{
    public class UsuarioRepositorio : RepositorioBase<Usuario>, IUsuarioRepositorio
    {
        private readonly DbSet<Usuario> _usuario;

        public UsuarioRepositorio(ContextBase db) : base(db)
        {
            _usuario = db.Set<Usuario>();
        }

        public async Task<Usuario> ObterEmail(string email)
        {
            return await _usuario
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Email == email);
        }

    }
}
