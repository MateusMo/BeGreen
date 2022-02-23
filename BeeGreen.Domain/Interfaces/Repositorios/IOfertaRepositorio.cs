using BeGreen.Domain.Entidades;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BeGreen.Domain.Interfaces.Repositorios
{
    public interface IOfertaRepositorio : IRepositorioGenerico<Oferta>
    {
        Task<List<Oferta>> ListarOfertas();

        IEnumerable<Oferta> ListarOfertasParceiro(int codigoParceiro);

        IEnumerable<Oferta> ListarOfertasEncerradas();

        IEnumerable<Oferta> ListarOfertasEncerradasPorParceiro(int codigoParceiro);

        IEnumerable<Oferta> ListarOfertasPorLocalidadePorParceiro(double latitude, double longitude, int codigoParceiro);

        IEnumerable<Oferta> ListarOfertasPorLocalidade(double latitude, double longitude);

        IEnumerable<Oferta> ListarOfertasPorLocalidadeEncerrada(double latitude, double longitude);
    }
}
