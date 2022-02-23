using BeGreen.Domain.Entidades;
using BeGreen.Domain.Interfaces.Repositorios;
using BeGreen.Infra.Contexto;
using System.Collections.Generic;

namespace BeGreen.Application.Applications
{
    public class OfertaApplication : BaseApplication
    {
        private readonly IOfertaRepositorio _ofertaRepositorio;

        public OfertaApplication(IOfertaRepositorio ofertaRepositorio, ContextBase db) : base(db)
        {
            _ofertaRepositorio = ofertaRepositorio;
        }

        public IEnumerable<Oferta> ObterOfertasParceiro(int codigoParceiro)
        {
            return _ofertaRepositorio.ListarOfertasParceiro(codigoParceiro);
        }

        public IEnumerable<Oferta> GetAll()
        {
            return _ofertaRepositorio.Get();
        }

        public Oferta Get(int id)
        {
            return _ofertaRepositorio.Get(id);
        }

        public void Add(Oferta obj)
        {
            _ofertaRepositorio.Add(obj);
            Commit();
        }

        public void Update(Oferta obj)
        {
            _ofertaRepositorio.Update(obj);
            Commit();
        }
        public void Delete(int obj)
        {
            _ofertaRepositorio.Delete(obj);
            Commit();
        }
    }
}
