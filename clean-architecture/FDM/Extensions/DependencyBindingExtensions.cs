using FDM.Domain.Repositories;
using FDM.Domain.Services;
using FDM.Persistence.Repositories;
using FDM.Services;

namespace FDM.Extensions
{
    public static class DependencyBindingExtensions
    {
        public static void ConfigureToBindDependencies(this IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddScoped<ITicketCategoryRespository, TicketCategoryRepository>();
            services.AddScoped<ITicketCategoryService, TicketCategoryService>();

            services.AddScoped<ITicketRespository, TicketRepository>();
            services.AddScoped<ITicketService, TicketService>();
        }
    }
}