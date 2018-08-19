using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

namespace DataLayer.RepositoryAndUnitOfWork
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        DbSet<TEntity> dbSet;
        SamplePracticeDbEntities dbContext;
        public GenericRepository(SamplePracticeDbEntities context)
        {
            dbContext = context;
            dbSet = dbContext.Set<TEntity>();
        }

        public void Add(TEntity entity)
        {
            dbSet.Add(entity);
        }
        
        public IEnumerable<TEntity> GetAllRecords()
        {
            return dbSet.ToList();
        }

        public TEntity GetFirstOrDefault(int id)
        {
            return dbSet.Find(id);                    
        }
        
        public void Update(TEntity entity)
        {
            dbSet.Attach(entity);
            dbContext.Entry(entity).State = EntityState.Modified;
        }

        public void Delete(TEntity entity)
        {
            if(dbContext.Entry(entity).State == EntityState.Detached )
            {
                dbSet.Attach(entity);
            }
            dbSet.Remove(entity);
        }

        public bool CheckIfUserExisits(string userName)
        {
            var result = dbContext.Database.SqlQuery<bool>("dbo.CheckIfUserExists @p0", userName).FirstOrDefault();
            return result;
        }

        public int LoginMember(string userName, string password)
        {
            var result = dbContext.Database.SqlQuery<int>("dbo.LoginMember @p0,@p1",userName,password).FirstOrDefault();
            return result;
        }    
    }
}
