using Microsoft.EntityFrameworkCore;
using PasswordStorage.Data.Database.Context;
using PasswordStorage.Data.Entities;
using PasswordStorage.Domain.Logic.Repository.General.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordStorage.Domain.Logic.Repository.Repositories.StorageItemRepository
{
    public class StorageItemRepository : GenericRepository<StorageItem>, IStorageItemRepository
    {
        public StorageItemRepository(
            PasswordStorageDbContext dbContext,
            DbSet<StorageItem> dbSet) : base(dbContext, dbSet)
        {
        }
    }
}
