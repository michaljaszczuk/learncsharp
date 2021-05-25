using GraphQL_API.Models;
using HotChocolate;
using HotChocolate.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQL_API.GraphQL
{
    public class Subscription
    {
        [Subscribe]
        [Topic]
        public FoodModel OnFoodAdded([EventMessage] FoodModel food) => food;
    }
}
