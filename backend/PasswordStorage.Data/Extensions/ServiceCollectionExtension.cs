using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using PasswordStorage.Data.Database.Context;

namespace PasswordStorage.Data.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static void RegisterServices(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<PasswordStorageDbContext>();
        }
    }
}
