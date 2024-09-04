using Core.DataAcccess;
using Core.Entities.Abstract;
using Microsoft.EntityFrameworkCore;

namespace Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity : Entity<Guid>
        where TContext : DbContext
    {
        private readonly TContext Context;
        public EfEntityRepositoryBase(TContext context)
        {
            this.Context = context;
        }

        public TEntity Add(TEntity entity)
        {
            entity.CreatedAt = DateTime.Now;
            Context.Add(entity);
            Context.SaveChanges();
            return entity;
        }

        public TEntity Delete(TEntity entity, bool isSoftDelete = true)
        {
            entity.DeletedAt = DateTime.UtcNow;
            Context.Entry(entity).State = EntityState.Modified;

            if (isSoftDelete)
                Context.Remove(entity);

            Context.SaveChanges();
            return entity;
        }

        public TEntity? Get(Func<TEntity, bool> predicate)
        {
            return Context.Set<TEntity>().FirstOrDefault(predicate);
        }

        public IList<TEntity> GetList(Func<TEntity, bool>? predicate = null)
        {
            IQueryable<TEntity> entities = Context.Set<TEntity>();

            if (predicate != null)
                entities = entities.Where(predicate).AsQueryable();

            return entities.ToList();
        }

        public TEntity Update(TEntity entity)
        {
            entity.UpdatedAt = DateTime.UtcNow;
            Context.Update(entity);
            Context.SaveChanges();
            return entity;
        }
    }
}
