using AutoMapper;
using Microsoft.EntityFrameworkCore.Query.Internal;
using Restaurantly.Entity.Dtos;
using Restaurantly.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurantly.Services.AutoMapper.Profiles
{
    public class ContactProfile  : Profile
    {
        public ContactProfile()
        {
            CreateMap<ContactAddDto, Contact>().ReverseMap();
            CreateMap<ContactUpdateDto, Contact>().ReverseMap();
        }
    }
}
