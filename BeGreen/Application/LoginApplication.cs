using BeGreen.Context;
using BeGreen.InterfaceRepositorio;
using BeGreen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeGreen.Application
{
    public class LoginApplication : BaseApplication
    {
        private readonly ILoginRepositorio _loginRepositorio;

        public LoginApplication(ILoginRepositorio loginRepositorio, ContextBase db) : base(db)
        {
            _loginRepositorio = loginRepositorio;
        }

        public void Add(Login obj)
        {
            _loginRepositorio.Add(obj);
            Commit();
        }
    }
}
