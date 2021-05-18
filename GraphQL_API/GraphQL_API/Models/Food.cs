using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQL_API.Models
{
    public class Food
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Group { get; set; }
        public int Calories { get; set; }
        public double Proteins { get; set; }
        public double Carbs { get; set; }
    }
}
