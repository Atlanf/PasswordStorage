using Microsoft.EntityFrameworkCore;
using PasswordStorage.Data.Database.Context;
using PasswordStorage.Domain.Logic.Repository.Repositories.StorageItemRepository;
using PasswordStorage.Domain.Logic.Repository.Repositories.StorageItemTypeRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PasswordStorage.Domain.Logic.Repository.General.GenericRepository;

namespace PasswordStorage.Domain.Logic.Repository.General.UnitOfWork
{
    public class UnitOfWork : IAsyncDisposable
    {
        public readonly IStorageItemTypeRepository StorageItemType;
        public readonly IStorageItemRepository StorageItem;

        private readonly PasswordStorageDbContext _dbContext;

        public UnitOfWork(PasswordStorageDbContext dbContext,
            IStorageItemTypeRepository storageItemType,
            IStorageItemRepository storageItem)
        {
            _dbContext = dbContext;

            StorageItemType = storageItemType;
            StorageItem = storageItem;
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
