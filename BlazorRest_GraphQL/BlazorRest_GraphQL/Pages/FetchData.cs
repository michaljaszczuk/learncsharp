using BlazorRest_GraphQL.DTOs;
using Microsoft.AspNetCore.Components;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace BlazorRest_GraphQL.Pages
{
    public partial class FetchData
    {
        [Inject]
        private HttpClient Http { get; set; }
        private LaunchDto[] launches;

        protected override async Task OnInitializedAsync()
        {
            launches = await Http.GetFromJsonAsync<LaunchDto[]>("/rest/launches/");
        }
    }
}
