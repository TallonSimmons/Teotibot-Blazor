using Microsoft.Extensions.DependencyInjection;
using System.Linq;
using Teotibot.Core.Store;
using Teotibot.Infrastructure.Stores;

namespace Teotibot.Application.Composition
{
    internal static class StoreRegistration
    {
        internal static IServiceCollection AddStores(this IServiceCollection services)
        {
            var implementedStores = typeof(PyramidTileStore)
                .Assembly
                .GetTypes()
                .Where(x => x.GetInterfaces().Contains(typeof(IReadStore<>)) && !x.IsAbstract);

            foreach (var store in implementedStores)
            {
                services.AddSingleton(store);
            }

            return services;
        }
    }
}
