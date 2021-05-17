using BlazorRest_GraphQL.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorRest_GraphQL.DataServices
{
    public interface ISpaceXDataService
    {
        Task<LaunchDto[]> GetAllLaunches();
    }
}
