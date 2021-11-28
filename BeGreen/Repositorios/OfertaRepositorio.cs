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
    public class OfertaRepositorio : RepositorioBase<Oferta>, IOfertaRepositorio
    {
        private readonly DbSet<Oferta> _oferta;

        public OfertaRepositorio(ContextBase db) : base(db)
        {
            _oferta = db.Set<Oferta>();
        }


    }
}
