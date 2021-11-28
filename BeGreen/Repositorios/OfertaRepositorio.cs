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

        public async Task<List<Oferta>> ListarOfertas()
        {
            return await _oferta
                .Include(x => x.Parceiro)
                .AsNoTracking()
                .ToListAsync();
        }

        public IEnumerable<Oferta> ListarOfertasParceiro(int codigoParceiro)
        {
            return _oferta
                .AsNoTracking()
                .Where(x => x.CodigoParceiro == codigoParceiro && x.DataFinal.Date <= DateTime.Now.Date);
        }

        public IEnumerable<Oferta> ListarOfertasEncerradas()
        {
            return _oferta
                .AsNoTracking()
                .Where(x => x.DataFinal.Date > DateTime.Now.Date);
        }

        public IEnumerable<Oferta> ListarOfertasEncerradasPorParceiro(int codigoParceiro)
        {
            return _oferta
                .Include(x => x.Parceiro)
                .AsNoTracking()
                .Where(x => x.DataFinal.Date > DateTime.Now.Date && x.CodigoParceiro == codigoParceiro);
        }

        public IEnumerable<Oferta> ListarOfertasPorLocalidadePorParceiro(double latitude, double longitude, int codigoParceiro)
        {
            return _oferta
                .AsNoTracking()
                .Where(x => x.DataFinal.Date <= DateTime.Now.Date && x.Latitude == latitude && x.Longitude == longitude && x.CodigoParceiro == codigoParceiro);
        }

        public IEnumerable<Oferta> ListarOfertasPorLocalidade(double latitude, double longitude)
        {
            return _oferta
                .AsNoTracking()
                .Where(x => x.DataFinal.Date <= DateTime.Now.Date && x.Latitude == latitude && x.Longitude == longitude);
        }

        public IEnumerable<Oferta> ListarOfertasPorLocalidadeEncerrada(double latitude, double longitude)
        {
            return _oferta
                .AsNoTracking()
                .Where(x => x.DataFinal.Date > DateTime.Now.Date && x.Latitude == latitude && x.Longitude == longitude);
        }

    }
}
