using BlazorRest_GraphQL.DataServices;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace BlazorRest_GraphQL
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.Configuration["api_base_url"]) });

            // to use REST implementation, swap below GraphQLSpaceXDataService with RESTSpaceXDataService
            builder.Services.AddHttpClient<ISpaceXDataService, GraphQLSpaceXDataService>
                (spds => spds.BaseAddress = new Uri(builder.Configuration["api_base_url"]));

            await builder.Build().RunAsync();
        }
    }
}
