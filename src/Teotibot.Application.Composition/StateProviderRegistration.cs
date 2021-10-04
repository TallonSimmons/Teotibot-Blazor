using Microsoft.Extensions.DependencyInjection;
using System.Linq;
using System.Reflection;
using Teotibot.Core.Store;

namespace Teotibot.Application.Composition
{
    internal static class StateProviderRegistration
    {
        internal static void AddStateProviders(this IServiceCollection services, Assembly[] assemblies)
        {
            var implementedStateProviders = assemblies
                .Select(x => x.GetTypes()
                // This is a hack until state types are moved into a presentation infra assembly
                .Where(t => t.BaseType.GetInterfaces()
                .Contains(typeof(IStateProvider)) && !t.IsAbstract && !t.IsInterface));

            foreach (var implementedStateProvider in implementedStateProviders)
            {
                services.AddSingleton(implementedStateProvider);
            }
        }
    }
}
