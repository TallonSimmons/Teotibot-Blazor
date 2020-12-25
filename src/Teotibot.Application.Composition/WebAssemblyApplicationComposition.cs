using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace Teotibot.Application.Composition
{
    public static class WebAssemblyApplicationComposition
    {
        public static WebAssemblyHostBuilder ComposeApplication(this WebAssemblyHostBuilder builder)
        {
            builder.Services
                .AddMediatr();

            return builder;
        }
    }
}
