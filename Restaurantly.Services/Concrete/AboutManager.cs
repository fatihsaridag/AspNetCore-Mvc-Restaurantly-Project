using AutoMapper;
using Restaurantly.Data.Abstract;
using Restaurantly.Entity.Dtos;
using Restaurantly.Entity.Entity;
using Restaurantly.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurantly.Services.Concrete
{
    public class AboutManager : IAboutService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;


        public AboutManager(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public void Add(AboutAddDto aboutAddDto)
        {
            var about = _mapper.Map<About>(aboutAddDto);
            _unitOfWork.Abouts.Add(about);
            _unitOfWork.SaveChanges();
        }

        public void Delete(int id)
        {
            var entity = _unitOfWork.Abouts.GetById(id);
            _unitOfWork.Abouts.Delete(entity);
            _unitOfWork.SaveChanges();
        }

        public AboutDto Get(int aboutId)
        {
            var about = _unitOfWork.Abouts.GetById(aboutId);
            if (about != null)
            {
                return new AboutDto
                {
                    About = about
                };
            }
            return new AboutDto
            {
                About = null
            };
        }

        public  AboutListDto GetAll()
        {
            var abouts =  _unitOfWork.Abouts.GetList();
            return new AboutListDto
            {
                Abouts = abouts
            };
        }

        public AboutUpdateDto GetbyAboutEdit(int aboutId)
        {
            var aboutEntity = _unitOfWork.Abouts.GetById(aboutId);
            var aboutUpdateDto = _mapper.Map<AboutUpdateDto>(aboutEntity);
            return aboutUpdateDto;
        }

        public void Update(AboutUpdateDto aboutUpdateDto)
        {
            var about = _mapper.Map<About>(aboutUpdateDto);
            _unitOfWork.Abouts.Update(about);
            _unitOfWork.SaveChanges();
        }
    }
}
