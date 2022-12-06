using Microsoft.EntityFrameworkCore;
using PasswordStorage.Data.Models;

namespace PasswordStorage.Data.Database.Context
{
    public class PasswordStorageDbContext : DbContext
    {
        private readonly IConfiguration _config;

        public DbSet<StorageItem> StorageItems { get; set; }
        public DbSet<StorageItemType> StorageItemTypes { get; set; }

        public PasswordStorageDbContext(IConfiguration config)
        {
            _config = config;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseNpgsql(_config.GetConnectionString("PostgreSQL"));
        }
    }
}
