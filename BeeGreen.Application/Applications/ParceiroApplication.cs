using BeGreen.Domain.Entidades;
using BeGreen.Domain.Interfaces.Repositorios;
using BeGreen.Infra.Contexto;
using System.Collections.Generic;

namespace BeGreen.Application.Applications
{
    public class ParceiroApplication : BaseApplication
    {
        private readonly IParceiroRepositorio _parceiroRepositorio;

        public ParceiroApplication(IParceiroRepositorio parceiroRepositorio, ContextBase db) : base(db)
        {
            _parceiroRepositorio = parceiroRepositorio;
        }

        public Parceiro ObterEmail(string email)
        {
            return _parceiroRepositorio.ObterEmail(email);
        }

        public IEnumerable<Parceiro> GetAll()
        {
            return _parceiroRepositorio.Get();
        }

        public Parceiro Get(int id)
        {
            return _parceiroRepositorio.Get(id);
        }

        public void Add(Parceiro obj)
        {
            _parceiroRepositorio.Add(obj);
            Commit();
        }

        public void Update(Parceiro obj)
        {
            _parceiroRepositorio.Update(obj);
            Commit();
        }
        public void Delete(int obj)
        {
            _parceiroRepositorio.Delete(obj);
            Commit();
        }
    }
}
