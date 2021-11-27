using BeGreen.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeGreen.Context
{
    public class ContextBase : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Parceiro> Parceiro { get; set; }

        public DbSet<Oferta> Ofertas { get; set; }

        public ContextBase(DbContextOptions<ContextBase> options) : base(options)
        {
            Database.EnsureCreated();
        }

    }
}
