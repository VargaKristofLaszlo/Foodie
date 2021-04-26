using AutoMapper;
using Foodie.Dal.DTOs;
using Foodie.Dal.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Foodie.Dal.MapperProfiles
{
    public class RecipeProfile : Profile
    {
        public RecipeProfile()
        {
            this.CreateMap<Recipe, RecipeDetails>().ReverseMap();
            this.CreateMap<Recipe, RecipePreview>().ReverseMap();
        }
    }
}
