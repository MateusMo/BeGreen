using BeGreen.Context;
using BeGreen.Interfaces;
using BeGreen.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeGreen.Repositorios
{
    public class UsuarioRepositorio : RepositorioGenerico<Usuario>, IUsuario
    {
        private readonly DbSet<Usuario> _usuario;

        public UsuarioRepositorio(DbContext db) : base(db)
        {
            _usuario = db.Set<Usuario>();
        }


    }
}
