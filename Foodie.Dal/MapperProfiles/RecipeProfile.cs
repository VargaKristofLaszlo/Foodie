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
            this.CreateMap<Recipe, RecipeDetails>()
                .ForMember(details => details.Id, mapper => mapper.MapFrom(recipe => recipe.Id))
                .ForMember(details => details.Category, mapper => mapper.MapFrom(recipe => (int)recipe.Category))
                .ForMember(details => details.PreparationTime, mapper => mapper.MapFrom(recipe => recipe.PreparationTime.TotalSeconds))
                .ForMember(details => details.CookingTime, mapper => mapper.MapFrom(recipe => recipe.CookingTime.TotalSeconds))
                .ForMember(details => details.Name, mapper => mapper.MapFrom(recipe => recipe.Name))
                .ForMember(details => details.Ingredients, mapper => mapper.MapFrom(recipe => recipe.Ingredients))
                .ForMember(details => details.Instruction, mapper => mapper.MapFrom(recipe => recipe.Instruction));
            ;

            this.CreateMap<RecipeDetails, Recipe>()
                .ForMember(recipe => recipe.Id, mapper => mapper.MapFrom(details => details.Id))
                .ForMember(recipe => recipe.Category, mapper => mapper.MapFrom(details => (Category)details.Category))
                .ForMember(recipe => recipe.PreparationTime, mapper => mapper.MapFrom(details => new TimeSpan(0, 0, details.PreparationTime)))
                .ForMember(recipe => recipe.CookingTime, mapper => mapper.MapFrom(details => new TimeSpan(0, 0, details.CookingTime)))
                .ForMember(recipe => recipe.Name, mapper => mapper.MapFrom(details => details.Name))
                .ForMember(recipe => recipe.Ingredients, mapper => mapper.MapFrom(details => details.Ingredients))
                .ForMember(recipe => recipe.Instruction, mapper => mapper.MapFrom(details => details.Instruction));
            ;



            this.CreateMap<Recipe, RecipePreview>()
                .ForMember(preview => preview.CookingTime, mapper => mapper.MapFrom(recipe => recipe.CookingTime.TotalSeconds))
                .ForMember(preview => preview.PreparationTime, mapper => mapper.MapFrom(recipe => recipe.PreparationTime.TotalSeconds))
                .ForMember(preview => preview.Name, mapper => mapper.MapFrom(recipe => recipe.Name))
                .ForMember(preview => preview.Id, mapper => mapper.MapFrom(recipe => recipe.Id));
        }
    }
}
