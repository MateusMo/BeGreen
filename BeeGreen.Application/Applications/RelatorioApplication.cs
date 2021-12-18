using BeGreen.Domain.Entidades;
using BeGreen.Domain.Interfaces.Repositorios;
using BeGreen.Infra.Contexto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BeGreen.Application.Applications
{
    public class RelatorioApplication : BaseApplication
    {
        private readonly IOfertaRepositorio _ofertaRepositorio;

        public RelatorioApplication(IOfertaRepositorio ofertaRepositorio, ContextBase db) : base(db)
        {
            _ofertaRepositorio = ofertaRepositorio;
        }

        public async Task<List<Oferta>> ListarOfertas()
        {
            return await _ofertaRepositorio.ListarOfertas();
        }

        public IEnumerable<Oferta> ListarOfertasParceiro(int codigoParceiro)
        {
            return _ofertaRepositorio.ListarOfertasParceiro(codigoParceiro);
        }

        public IEnumerable<Oferta> ListarOfertasEncerradas()
        {
            return _ofertaRepositorio.ListarOfertasEncerradas();
        }

        public IEnumerable<Oferta> ListarOfertasEncerradasPorParceiro(int codigoParceiro)
        {
            return _ofertaRepositorio.ListarOfertasEncerradasPorParceiro(codigoParceiro);
        }

        public IEnumerable<Oferta> ListarOfertasPorLocalidadePorParceiro(double latitude, double longitude, int codigoParceiro)
        {
            return _ofertaRepositorio.ListarOfertasPorLocalidadePorParceiro(latitude, longitude, codigoParceiro);
        }

        public IEnumerable<Oferta> ListarOfertasPorLocalidade(double latitude, double longitude)
        {
            return _ofertaRepositorio.ListarOfertasPorLocalidade(latitude, longitude);
        }

        public IEnumerable<Oferta> ListarOfertasPorLocalidadeEncerrada(double latitude, double longitude)
        {
            return _ofertaRepositorio.ListarOfertasPorLocalidadeEncerrada(latitude, longitude);
        }


    }
}
