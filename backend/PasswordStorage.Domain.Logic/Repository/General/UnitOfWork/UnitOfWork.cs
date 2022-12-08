using Microsoft.EntityFrameworkCore;
using PasswordStorage.Data.Database.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordStorage.Domain.Logic.Repository.General.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
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
