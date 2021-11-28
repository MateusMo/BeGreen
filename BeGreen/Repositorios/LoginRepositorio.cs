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
    public class LoginRepositorio : RepositorioBase<Login>, ILoginRepositorio
    {
        private readonly DbSet<Login> _login;

        public LoginRepositorio(ContextBase db) : base(db)
        {
            _login = db.Set<Login>();
        }

        public Login Login(string email, string senha)
        {
            return _login
                .Include(x => x.Usuario)
                .Include(x => x.Parceiro)
                .AsNoTracking()
                .FirstOrDefault(x => x.Email == email.ToLower() && x.Senha == senha);
        }

    }
}
