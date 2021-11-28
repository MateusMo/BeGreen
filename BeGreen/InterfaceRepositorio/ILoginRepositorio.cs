using BeGreen.InterfacesGenericas;
using BeGreen.Models;
using BeGreen.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeGreen.InterfaceRepositorio
{
    public interface ILoginRepositorio : IRepositorioGenerico<Login>
    {
        Login Login(string email, string senha);
    }
}
