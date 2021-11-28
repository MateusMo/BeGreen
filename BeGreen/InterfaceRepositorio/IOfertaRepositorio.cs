using BeGreen.InterfacesGenericas;
using BeGreen.Models;
using BeGreen.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeGreen.InterfaceRepositorio
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
