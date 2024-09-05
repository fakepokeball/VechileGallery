namespace Core.DataAcccess;

public interface IEntityRepository<TEntity>
    where TEntity : class
{
    Task<TEntity> AddAsync(TEntity entity);
    Task<TEntity> DeleteAsync(TEntity entity, bool isSoftDelete = true);
    Task<TEntity?> GetAsync(Func<TEntity, bool> predicate);
    Task<IList<TEntity>> GetListAsync(Func<TEntity, bool>? predicate = null);
    Task<TEntity> UpdateAsync(TEntity entity);
}