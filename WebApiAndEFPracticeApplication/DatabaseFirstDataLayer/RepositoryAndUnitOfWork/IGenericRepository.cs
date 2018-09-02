using System.Collections.Generic;

namespace DatabaseFirstDataLayer.RepositoryAndUnitOfWork
{
    public interface IGenericRepository<TEntity>
    {
        IEnumerable<TEntity> GetAllRecords();
        TEntity GetFirstOrDefault(int id);
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
    }
}
