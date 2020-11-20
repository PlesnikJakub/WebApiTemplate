using Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace WebApi.Modules
{
    public static class PersistenceExtension
    {
        public static void AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<MyDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("ContentApiContext"), b => b.MigrationsAssembly("Infrastructure")));
        }
    }
}
