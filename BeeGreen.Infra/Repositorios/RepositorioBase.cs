using BeGreen.Domain.Interfaces.Repositorios;
using BeGreen.Infra.Contexto;
using Microsoft.EntityFrameworkCore;
using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace BeGreen.Repositorios
{
    public abstract class RepositorioBase<TEntity> : IRepositorioGenerico<TEntity>, IDisposable where TEntity : class
    {
        protected ContextBase Context { get; }

        public RepositorioBase(ContextBase db)
        {
            Context = db;
        }

        public TEntity Get(int id)
        {
            return Context.Set<TEntity>().Find(id);
        }
        public TEntity Get(string id)
        {
            return Context.Set<TEntity>().Find(id);
        }
        public IEnumerable<TEntity> Get()
        {
            return Context.Set<TEntity>().ToList();
        }

        public async Task<IEnumerable<TEntity>> GetAsync()
        {
            return await Context.Set<TEntity>().ToListAsync();
        }

        public TEntity Add(TEntity obj)
        {
            return Context.Set<TEntity>().Add(obj).Entity;
        }

        public void Update(TEntity obj)
        {
            Context.Entry(obj).State = EntityState.Modified;
        }

        public void Delete(TEntity obj)
        {
            Context.Set<TEntity>().Remove(obj);
        }

        public void Delete(int id)
        {
            Context.Set<TEntity>().Remove(Get(id));
        }

        #region Disposed https://docs.microsoft.com/pt-br/dotnet/standard/garbage-collection/implementing-dispose
        // Flag: Has Dispose already been called?
        bool disposed = false;

        // Instantiate a SafeHandle instance.
        readonly SafeHandle handle = new SafeFileHandle(IntPtr.Zero, true);



        // Public implementation of Dispose pattern callable by consumers.
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }


        // Protected implementation of Dispose pattern.
        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;

            if (disposing)
            {
                handle.Dispose();
                // Free any other managed objects here.
                //
            }

            disposed = true;
        }
        #endregion
    }
}