using Microsoft.EntityFrameworkCore;
using PasswordStorage.Data.Database.Context;
using PasswordStorage.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordStorage.Domain.Logic.Repository.General.GenericRepository
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity>
            where TEntity : BaseEntity
    {
        private readonly PasswordStorageDbContext _dbContext;
        public readonly DbSet<TEntity> _dbSet;

        public GenericRepository(PasswordStorageDbContext dbContext,
            DbSet<TEntity> dbSet)
        {
            _dbContext = dbContext;
            _dbSet = dbSet;
        }

        public virtual async Task<TEntity> GetByIdAsync(Guid id)
        {
            return await _dbSet.FirstOrDefaultAsync(entity => entity.Id == id);
        }

        public virtual async Task<Guid> InsertAsync(TEntity entityToSave)
        {
            entityToSave.Initialize();
            await _dbSet.AddAsync(entityToSave);

            return entityToSave.Id;
        }

        public virtual async Task<Guid> UpdateAsync(TEntity entityToUpdate)
        {
            if (!(await _dbSet.AnyAsync(entity => entity.Id == entityToUpdate.Id)))
            {
                throw new KeyNotFoundException("Entity not found");
            }

            _dbSet.Attach(entityToUpdate);

            return entityToUpdate.Id;
        }

        public virtual IQueryable<TEntity> GetAll()
        {
            return _dbSet;
        }

        public virtual async Task DeleteAsync(Guid id, bool softDelete = false)
        {
            var entityToDelete = await _dbContext.FindAsync<TEntity>(id);

            if (entityToDelete == null)
            {
                throw new KeyNotFoundException("Entity not found");
            }

            if (softDelete == true)
            {
                entityToDelete.IsDeleted = true;
                await this.UpdateAsync(entityToDelete);

                return;
            }
            
            if (_dbContext.Entry(entityToDelete).State == EntityState.Detached)
            {
                _dbSet.Attach(entityToDelete);
            }
            _dbSet.Remove(entityToDelete);
        }
    }
}
