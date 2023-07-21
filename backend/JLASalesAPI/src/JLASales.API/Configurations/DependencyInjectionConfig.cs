using JLASales.Business.Interfaces;
using JLASales.Data.Context;
using JLASales.Data.Repository;

namespace JLASales.API.Configurations
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<JLASalesDbContext>();

            services.AddScoped<IVendorRepository, VendorRepository>();

            return services;
        }
    }
}
