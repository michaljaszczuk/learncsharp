using BlazorRest_GraphQL.DataServices;
using BlazorRest_GraphQL.DTOs;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorRest_GraphQL.Pages
{
    public partial class Launches
    {
        [Inject]
        ISpaceXDataService SpaceXDataService { get; set; }
        private LaunchDto[] launches;
        protected override async Task OnInitializedAsync()
        {
            launches = await SpaceXDataService.GetAllLaunches();
            
        }
    }
}
