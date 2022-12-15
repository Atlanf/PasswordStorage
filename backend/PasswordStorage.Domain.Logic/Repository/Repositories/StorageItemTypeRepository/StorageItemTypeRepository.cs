using Microsoft.EntityFrameworkCore;
using PasswordStorage.Data.Database.Context;
using PasswordStorage.Data.Entities;
using PasswordStorage.Domain.Logic.Repository.General.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordStorage.Domain.Logic.Repository.Repositories.StorageItemTypeRepository
{
    public class StorageItemTypeRepository : GenericRepository<StorageItemType>, IStorageItemTypeRepository
    {
        public StorageItemTypeRepository(
            PasswordStorageDbContext dbContext,
            DbSet<StorageItemType> dbSet) : base(dbContext, dbSet)
        {
        }
    }
}
