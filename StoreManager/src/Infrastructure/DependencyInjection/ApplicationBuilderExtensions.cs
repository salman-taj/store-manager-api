using Hangfire;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.FileProviders;
using StoreManager.Infrastructure.Common.Extensions;
using StoreManager.Infrastructure.Hubs;
using StoreManager.Infrastructure.Identity.Extensions;
using StoreManager.Infrastructure.Multitenancy;
using StoreManager.Infrastructure.Swagger;
using System.Globalization;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("StoreManager.Host")]

namespace StoreManager.Infrastructure.DependencyInjection
{
    internal static class ApplicationBuilderExtensions
    {
        public static IApplicationBuilder UseInfrastructure(this IApplicationBuilder app, IConfiguration config)
        {
            var options = new RequestLocalizationOptions
            {
                DefaultRequestCulture = new RequestCulture(new CultureInfo("en-US"))
            };
            app.UseRequestLocalization(options);
            app.UseStaticFiles();
            app.UseStaticFiles(new StaticFileOptions()
            {
                FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), "Files")),
                RequestPath = new PathString("/Files")
            });
            app.UseMiddlewares(config);
            app.UseRouting();
            app.UseCors("CorsPolicy");
            app.UseAuthentication();
            app.UseMiddlewareCurrentUser();
            app.UseMiddlewareTenant();
            app.UseAuthorization();
            var configDashboard = config.GetSection("HangFireSettings:Dashboard").Get<DashboardOptions>();
            app.UseHangfireDashboard(config["HangFireSettings:Route"], new DashboardOptions
            {
                DashboardTitle = configDashboard.DashboardTitle,
                StatsPollingInterval = configDashboard.StatsPollingInterval,
                AppPath = configDashboard.AppPath

                // ** OPtional BasicAuthAuthorizationFilter **
                // Authorization = new[] { new BasicAuthAuthorizationFilter(
                //    new BasicAuthAuthorizationFilterOptions {
                //        RequireSsl = false,
                //        SslRedirect = false,
                //        LoginCaseSensitive = true,
                //        Users = new []
                //        {
                //            new BasicAuthAuthorizationUser
                //            {
                //                Login = config["HangFireSettings:Credentiales:User"],
                //                PasswordClear =  config["HangFireSettings:Credentiales:Password"]
                //            }
                //        }
                //    })
                // }
            });
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers().RequireAuthorization();
                endpoints.MapHealthChecks("/api/health").RequireAuthorization();
                endpoints.MapHub<NotificationHub>("/notifications", options =>
                {
                    options.CloseOnAuthenticationExpiration = true;
                });
            });
            app.UseSwaggerDocumentation(config);
            return app;
        }
    }
}