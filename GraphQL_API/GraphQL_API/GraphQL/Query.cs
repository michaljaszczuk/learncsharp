using GraphQL_API.Data;
using GraphQL_API.Models;
using HotChocolate;
using HotChocolate.Data;
using System.Linq;

namespace GraphQL_API.GraphQL
{
    public class Query
    {
        [UseDbContext(typeof(AppDbContext))]
        public IQueryable<Food> GetFood([ScopedService] AppDbContext context)
        {
            return context.FoodTable;
        }
    }
}
