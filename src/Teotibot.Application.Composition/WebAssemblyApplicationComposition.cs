using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using System.Reflection;

namespace Teotibot.Application.Composition
{
    public static class WebAssemblyApplicationComposition
    {
        public static WebAssemblyHostBuilder ComposeApplication(this WebAssemblyHostBuilder builder, Assembly callingAssembly)
        {
            builder.Services
                .AddEntityFramework()
                .AddStores()
                .AddMediatr()
                .AddStateProviders(new[] { callingAssembly });

            return builder;
        }
    }
}
