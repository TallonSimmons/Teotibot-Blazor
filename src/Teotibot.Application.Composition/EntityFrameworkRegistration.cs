using Microsoft.Extensions.DependencyInjection;
using Teotibot.Core.Repositories;
using Teotibot.Infrastructure.Repositories;

namespace Teotibot.Application.Composition
{
    internal static class EntityFrameworkRegistration
    {
        public static IServiceCollection AddEntityFramework(this IServiceCollection services)
        {
            services.AddSingleton<IRepository, EntityFrameworkRepository>();
            
            return services;
        }
    }
}
