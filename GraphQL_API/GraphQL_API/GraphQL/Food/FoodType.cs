using GraphQL_API.Data;
using GraphQL_API.Models;
using HotChocolate;
using HotChocolate.Types;
using System.Linq;

namespace GraphQL_API.GraphQL.Food
{
    public class FoodType : ObjectType<FoodModel>
    {
        protected override void Configure(IObjectTypeDescriptor<FoodModel> descriptor)
        {
            descriptor.Description("Food data.");
            descriptor
                .Field(p => p.Id)
                .ResolveWith<Resolvers>(p => p.GetFoodData(default!, default!))
                .UseDbContext<AppDbContext>();


        }

        private class Resolvers
        {

            public IQueryable<FoodModel> GetFoodData(FoodModel foodModel, [ScopedService] AppDbContext context)
            {

                return context.FoodTable.Where(p => p.Id == foodModel.Id);
            }

        }
    }
}