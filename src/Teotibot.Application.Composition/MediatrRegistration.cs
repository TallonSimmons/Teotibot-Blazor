using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Teotibot.Application.Queries;

namespace Teotibot.Application.Composition
{
    public static class MediatrRegistration
    {
        public static IServiceCollection AddMediatr(this IServiceCollection services)
        {
            services.AddMediatR(typeof(SavedGamesQuery));
            return services;
        }
    }
}
