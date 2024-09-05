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

        public async Task<TEntity> AddAsync(TEntity entity)
        {
            entity.CreatedAt = DateTime.Now;
            await Context.AddAsync(entity);
            await Context.SaveChangesAsync();
            return entity;
        }

        public async Task<TEntity> DeleteAsync(TEntity entity, bool isSoftDelete = true)
        {
            entity.DeletedAt = DateTime.UtcNow;
            Context.Entry(entity).State = EntityState.Modified;

            if (isSoftDelete)
                Context.Remove(entity);

            await Context.SaveChangesAsync();
            return entity;
        }

        public async Task<TEntity?> GetAsync(Func<TEntity, bool> predicate)
        {
            return await Task.Run(() => Context.Set<TEntity>().FirstOrDefault(predicate));
        }

        public async Task<IList<TEntity>> GetListAsync(Func<TEntity, bool>? predicate = null)
        {
            IQueryable<TEntity> entities = Context.Set<TEntity>();

            if (predicate != null)
                entities = entities.Where(predicate).AsQueryable();

            return await entities.ToListAsync();
        }

        public async Task<TEntity> UpdateAsync(TEntity entity)
        {
            entity.UpdatedAt = DateTime.UtcNow;
            Context.Update(entity);
            await Context.SaveChangesAsync();
            return entity;
        }
    }
}
