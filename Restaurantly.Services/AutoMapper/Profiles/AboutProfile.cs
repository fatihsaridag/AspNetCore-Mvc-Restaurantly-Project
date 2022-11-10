﻿using AutoMapper;
using Restaurantly.Entity.Dtos;
using Restaurantly.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurantly.Services.AutoMapper.Profiles
{
    public class AboutProfile : Profile
    {
        public AboutProfile()
        {
            CreateMap<AboutAddDto, About>().ReverseMap();
            CreateMap<AboutUpdateDto, About>().ReverseMap();
        }
    }
}
