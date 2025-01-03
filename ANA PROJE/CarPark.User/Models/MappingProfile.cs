﻿using AutoMapper;
using CarPark.Entities.concrete;
using CarPark.Models.ViewModels.Personels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarPark.User.Models
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Personel, PersonelProfileInfo>().ReverseMap();
        }
    }
}
