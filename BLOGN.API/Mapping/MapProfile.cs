﻿using AutoMapper;
using BLOGN.Models;
using BLOGN.Models.Dto;

namespace BLOGN.API.Mapping
{
    public class MapProfile:Profile
    {
        public MapProfile()
        {
            CreateMap<Category, CategoryDto>().ReverseMap();
        }
    }
}