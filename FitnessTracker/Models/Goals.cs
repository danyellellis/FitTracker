using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessTracker.Models
{
    public class Goals
    {
        [Key]

        public int Id { get; set; }
        [Display(Name = "Goal")]
        public int Goal { get; set; }


    }
}
