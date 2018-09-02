using System;

namespace DatabaseFirstDataLayer.RepositoryAndUnitOfWork
{
    public class GenericUnitOfWork : IDisposable
    {
        SamplePracticeDbEntities dbContext;
        private bool disposed = false;

        public GenericUnitOfWork()
        {
            dbContext = new SamplePracticeDbEntities();
        }

        public GenericRepository<TEntity> GetRepoInstance<TEntity>() where TEntity:class
        {
            return new GenericRepository<TEntity>(dbContext);
        }

        public void SaveChanges()
        {
            dbContext.SaveChanges();
        }
        
        public void Dispose()
        {
            if (!this.disposed)
            {                
                dbContext.Dispose();
                GC.SuppressFinalize(this);         
            }
            this.disposed = true;
        }  
        
                   
    }
}
