using GraphQL_API.Data;
using GraphQL_API.Models;
using HotChocolate;
using HotChocolate.Types;
using HotChocolate.Data;
using System.Linq;


namespace GraphQL_API.GraphQL
{
    public class Query
    {
        [UseDbContext(typeof(AppDbContext))]
        [UseFiltering]
        [UseSorting]
        public IQueryable<FoodModel> GetFood([ScopedService] AppDbContext context)
        {
            return context.FoodTable;
        }
    }
}
