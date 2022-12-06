using PasswordStorage.Data.Database.Context;
using PasswordStorage.Data.Models;

namespace PasswordStorage.Data.Database.Infrastructure.Repository
{
    public interface IGenericRepository<TEntity>
        where TEntity : BaseModel
    {
        Task<TEntity> GetByIdAsync(Guid id);
        Task<Guid> InsertAsync(TEntity saveEntity);
        Task<Guid> UpdateAsync(TEntity entity);
        IQueryable<TEntity> GetAll();
        Task DeleteAsync(Guid id);
    }
}
