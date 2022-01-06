using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using StoreManager.Application.Common.Interfaces;
using System.Reflection;

namespace StoreManager.Application.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddValidatorsFromAssemblyContaining<IRequestValidator>();
            services.AddMediatR(Assembly.GetExecutingAssembly());
            return services;
        }
    }
}