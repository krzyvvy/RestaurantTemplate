using AutoMapper;
using RestaurantTemplate_API1.Models.Enity;
using RestaurantTemplate_API1.Models.Information;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantTemplate_API1.Helpper
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Dish, DishInformation>();
            CreateMap<DishInformation, Dish>();
        }
    }
}
