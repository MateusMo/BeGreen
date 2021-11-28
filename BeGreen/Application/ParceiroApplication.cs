using BeGreen.Context;
using BeGreen.InterfaceRepositorio;
using BeGreen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeGreen.Application
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
