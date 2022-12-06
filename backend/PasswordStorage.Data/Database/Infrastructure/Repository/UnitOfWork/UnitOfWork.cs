using PasswordStorage.Data.Database.Context;

namespace PasswordStorage.Data.Database.Infrastructure.Repository.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork, IAsyncDisposable
    {
        private readonly PasswordStorageDbContext _dbContext;

        public UnitOfWork(PasswordStorageDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task SaveAllAsync()
        {
            await _dbContext.SaveChangesAsync();
        }

        public async ValueTask DisposeAsync()
        {
            await _dbContext.DisposeAsync();
        }
    }
}
