using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessTracker.Models
{
    public class Dashboard
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Steps")]
        public int Steps { get; set; }

        [Display(Name = "Body Weight")]
        public int BodyWeight { get; set; }

        [Display(Name = "Body Fat")]
        public int BodyFat { get; set; }
        [Display(Name = "Calories")]
        public int Calories { get; set; }
        [Display(Name = "Water Intake")]
        public int WaterIntake { get; set; }
    }
}
