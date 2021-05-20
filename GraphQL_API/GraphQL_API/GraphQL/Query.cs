using GraphQL_API.Data;
using GraphQL_API.Models;
using HotChocolate;
using System.Linq;

namespace GraphQL_API.GraphQL
{
    public class Query
    {
        public IQueryable<Food> GetFood([Service] AppDbContext context)
        {
            return context.FoodTable;
        }
    }
}
