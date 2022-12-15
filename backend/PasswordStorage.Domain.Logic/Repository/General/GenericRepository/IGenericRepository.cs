using PasswordStorage.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordStorage.Domain.Logic.Repository.General.GenericRepository
{
    public interface IGenericRepository<TEntity>
        where TEntity : BaseEntity
    {
        Task<TEntity> GetByIdAsync(Guid id);
        Task<Guid> InsertAsync(TEntity saveEntity);
        Task<Guid> UpdateAsync(TEntity entity);
        IQueryable<TEntity> GetAll();
        Task DeleteAsync(Guid id, bool softDelete = false);
    }
}
