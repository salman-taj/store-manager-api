using Microsoft.Extensions.DependencyInjection;
using StoreManager.Application.Settings;
using StoreManager.Infrastructure.Multitenancy;

namespace StoreManager.Infrastructure.Common.Extensions
{
    public static class CorsExtensions
    {
        internal static IServiceCollection AddCorsPolicy(this IServiceCollection services)
        {
            var corsSettings = services.GetOptions<CorsSettings>(nameof(CorsSettings));
            return services.AddCors(opt =>
            {
                opt.AddPolicy("CorsPolicy", policy =>
                {
                    policy.AllowAnyHeader().AllowAnyMethod().AllowCredentials().WithOrigins(new string[] { corsSettings.Angular, corsSettings.Blazor });
                });
            });
        }
    }
}