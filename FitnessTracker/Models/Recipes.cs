using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessTracker.Models
{
    public class Recipes
    {
        [Key]

        public int Id { get; set; }
        [Display(Name = "Recipe")]
        public string Recipe { get; set; }

    }
}
