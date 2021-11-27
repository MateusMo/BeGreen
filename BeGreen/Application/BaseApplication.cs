using BeGreen.Context;
using BeGreen.InterfacesGenericas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeGreen.Application
{
    public class BaseApplication : IBaseApplication
    {
        private readonly ContextBase _db;

        public BaseApplication(ContextBase db)
        {
            _db = db;
        }
        public void Commit()
        {
            _db.SaveChanges();
        }
    }
}
