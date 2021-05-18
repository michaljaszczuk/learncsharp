using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQL_API.Models
{
    public class Food
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Group { get; set; }
        public int Calories { get; set; }
        public double Protein { get; set; }
        public double Carbs { get; set; }
    }
}
