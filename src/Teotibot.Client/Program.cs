using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using System.Threading.Tasks;
using Teotibot.Application.Composition;
using Microsoft.Extensions.DependencyInjection;
using Teotibot.Client.Store;

namespace Teotibot.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.Services.AddSingleton(typeof(AppState));
            builder
                .ComposeApplication(typeof(Program).Assembly);

            await builder.Build().RunAsync();
        }
    }
}
