using BeGreen.Context;
using BeGreen.InterfaceRepositorio;
using BeGreen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeGreen.Application
{
    public class OfertaApplication : BaseApplication
    {
        private readonly IOfertaRepositorio _ofertaRepositorio;

        public OfertaApplication(IOfertaRepositorio ofertaRepositorio, ContextBase db) : base(db)
        {
            _ofertaRepositorio = ofertaRepositorio;
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
