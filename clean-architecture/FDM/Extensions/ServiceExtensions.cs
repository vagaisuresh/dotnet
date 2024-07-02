using FDM.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;

namespace FDM.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureSqlContext(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration["sqlconnection:connectionString"];
            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(connectionString));
        }
    }
}