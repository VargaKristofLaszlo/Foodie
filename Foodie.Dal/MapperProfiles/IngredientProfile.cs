using AutoMapper;
using Foodie.Dal.DTOs;
using Foodie.Dal.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Foodie.Dal.MapperProfiles
{
    public class IngredientProfile : Profile
    {
        public IngredientProfile()
        {
            this.CreateMap<Ingredient, IngredientDetails>().ReverseMap();
        }
    }
}
