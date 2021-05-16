using BlazorRest_GraphQL.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace BlazorRest_GraphQL.Pages
{
    public partial class FetchData
    {
        private LaunchDto[] launches;

        protected override async Task OnInitializedAsync()
        {
            launches = await Http.GetFromJsonAsync<LaunchDto[]>("https://api.spacex.land/rest/launches/");
        }
    }
}
