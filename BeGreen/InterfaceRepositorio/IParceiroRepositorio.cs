using BeGreen.InterfacesGenericas;
using BeGreen.Models;
using BeGreen.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeGreen.InterfaceRepositorio
{
    public interface IParceiroRepositorio : IRepositorioGenerico<Parceiro>
    {
        Task<List<Parceiro>> ListarParceiros();
    }
}
