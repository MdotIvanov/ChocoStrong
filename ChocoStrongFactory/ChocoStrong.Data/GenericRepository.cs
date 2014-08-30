using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Linq.Expressions;

namespace ChocoStrong.Data
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private IDatabaseContext mChocoStrongContext;
        private IDbSet<T> mSet;

        public GenericRepository(IDatabaseContext context)
        {
            this.mChocoStrongContext = context;
            this.mSet = context.Set<T>();
        }

        public IQueryable<T> All()
        {
            return mSet.AsQueryable();
        }

        public void Add(T entity)
        {
            var entry = AttachIfDetached(entity);
            entry.State = EntityState.Added;
        }

        public void Update(T entity)
        {
            var entry = AttachIfDetached(entity);
            entry.State = EntityState.Modified;
        }

        public void Delete(T entity)
        {
            var entry = AttachIfDetached(entity);
            entry.State = EntityState.Deleted;
        }

        public void Detach(T entity)
        {
            var entry = this.mChocoStrongContext.Entry(entity);
            entry.State = EntityState.Detached;
        }

        private DbEntityEntry AttachIfDetached(T entity)
        {
            var entry = mChocoStrongContext.Entry(entity);
            if (entry.State == EntityState.Detached)
            {
                mSet.Attach(entity);
            }

            return entry;
        }
    }
}
