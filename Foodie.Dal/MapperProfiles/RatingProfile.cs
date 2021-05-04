using AutoMapper;
using Foodie.Dal.DTOs;
using Foodie.Dal.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Foodie.Dal.MapperProfiles
{
    public class RatingProfile : Profile
    {
        public RatingProfile()
        {
            this.CreateMap<Rating, RatingDetails>()
                .ForMember(r => r.Comment, m => m.MapFrom(t => t.Comment))
                .ForMember(r => r.Username, m => m.MapFrom(t => t.User.UserName))
                .ForMember(r => r.Value, m => m.MapFrom(t => t.Value));
        }
    }
}
