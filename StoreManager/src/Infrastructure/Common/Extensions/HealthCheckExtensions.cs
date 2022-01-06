using Microsoft.Extensions.DependencyInjection;
using StoreManager.Infrastructure.Multitenancy;

namespace StoreManager.Infrastructure.Common.Extensions
{
    public static class HealthCheckExtensions
    {
        internal static IServiceCollection AddHealthCheckExtension(this IServiceCollection services)
        {
            services.AddHealthChecks().AddCheck<TenantHealthCheck>("Tenant");
            return services;
        }
    }
}