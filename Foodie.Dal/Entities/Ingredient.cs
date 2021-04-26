using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Foodie.Dal.Entities
{    
   
    public class Ingredient
    {

        [Required]
        public string Name { get; set; }

        [Required]
        public Measurement Measurement { get; set; }

        public double? Amount { get; set; }
    }
}
