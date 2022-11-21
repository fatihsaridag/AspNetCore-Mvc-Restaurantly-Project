using AutoMapper;
using Restaurantly.Entity.Dtos;
using Restaurantly.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurantly.Services.AutoMapper.Profiles
{
    public class SpecialProfile : Profile
    {
        public SpecialProfile()
        {
            CreateMap<SpecialAddDto, Special>().ReverseMap();
            CreateMap<SpecialUpdateDto, Special>().ReverseMap();
        }
    }
}
