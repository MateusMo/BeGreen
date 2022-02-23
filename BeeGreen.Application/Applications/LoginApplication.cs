using BeGreen.Domain.Entidades;
using BeGreen.Domain.Interfaces.Repositorios;
using BeGreen.Infra.Contexto;
using System.Collections.Generic;

namespace BeGreen.Application.Applications
{
    public class LoginApplication : BaseApplication
    {
        private readonly ILoginRepositorio _loginRepositorio;

        public LoginApplication(ILoginRepositorio loginRepositorio, ContextBase db) : base(db)
        {
            _loginRepositorio = loginRepositorio;
        }

        public Login Login(string email, string senha)
        { 
            return _loginRepositorio.Login(email, senha);
        }

        public IEnumerable<Login> GetAll()
        {
            return _loginRepositorio.Get();
        }

        public Login Get(int id)
        {
            return _loginRepositorio.Get(id);
        }

        public void Add(Login obj)
        {
            _loginRepositorio.Add(obj);
            Commit();
        }

        public void Update(Login obj)
        {
            _loginRepositorio.Update(obj);
            Commit();
        }
        public void Delete(int obj)
        {
            _loginRepositorio.Delete(obj);
            Commit();
        }
    }
}
