
using BeGreen.Infra.Contexto;

namespace BeGreen.Application.Applications
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

        public void CommitAsync()
        {
            _db.SaveChangesAsync();
        }
    }
}
