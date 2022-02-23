using BeGreen.Domain.Entidades;
using BeGreen.Domain.Interfaces.Repositorios;
using BeGreen.Infra.Contexto;
using System.Collections.Generic;

namespace BeGreen.Application.Applications
{
    public class UsuarioApplication : BaseApplication
    {
        private readonly IUsuarioRepositorio _usuarioReporitorio;

        public UsuarioApplication(IUsuarioRepositorio usuarioReporitorio, ContextBase db) : base(db)
        {
            _usuarioReporitorio = usuarioReporitorio;
        }

        public Usuario ObterEmail(string email)
        {
            return  _usuarioReporitorio.ObterEmail(email);
        }

        public IEnumerable<Usuario> GetAll()
        {
            return _usuarioReporitorio.Get();
        }

        public Usuario Get(int id)
        {
            return _usuarioReporitorio.Get(id);
        }

        public void Add(Usuario obj)
        {
            _usuarioReporitorio.Add(obj);
            Commit();
        }

        public void Update(Usuario obj)
        {
            _usuarioReporitorio.Update(obj);
            Commit();
        }
        public void Delete(int obj)
        {
            _usuarioReporitorio.Delete(obj);
            Commit();
        }
    }
}
