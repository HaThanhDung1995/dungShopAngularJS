using DungApplication.Model.Models;

namespace DungApplication.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private DataContext dbContext;

        public DataContext Init()
        {
            return dbContext ?? (dbContext = new DataContext());
        }

        protected virtual void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}