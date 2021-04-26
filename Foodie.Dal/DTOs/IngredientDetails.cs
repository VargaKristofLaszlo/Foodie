using Foodie.Dal.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Foodie.Dal.DTOs
{
    public class IngredientDetails
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public Measurement Measurement { get; set; }

       
        public double? Amount { get; set; }
    }
}
