using BeGreen.Domain.Entidades;
using BeGreen.Infra.Mapeamento;
using Microsoft.EntityFrameworkCore;

namespace BeGreen.Infra.Contexto
{
    public class ContextBase : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Parceiro> Parceiro { get; set; }

        public DbSet<Oferta> Ofertas { get; set; }

        public DbSet<Login> Login { get; set; }

        public ContextBase(DbContextOptions<ContextBase> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioMap());
            modelBuilder.ApplyConfiguration(new ParceiroMap());
            modelBuilder.ApplyConfiguration(new OfertaMap());
            modelBuilder.ApplyConfiguration(new LoginMap());
        }

    }
}
