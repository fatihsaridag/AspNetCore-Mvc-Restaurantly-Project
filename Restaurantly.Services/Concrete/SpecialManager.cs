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
    public class SpecialManager : ISpecialService
    {

        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;


        public SpecialManager(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public void Add(SpecialAddDto dto)
        {
            var specialEntity = _mapper.Map<Special>(dto);
            _unitOfWork.Specials.Add(specialEntity);
            _unitOfWork.SaveChanges();
        }

        public void Delete(int id)
        {
            var special = _unitOfWork.Specials.GetById(id);
            _unitOfWork.Specials.Delete(special);
            _unitOfWork.SaveChanges();
        }

        public SpecialDto Get(int specialId)
        {
            var special =  _unitOfWork.Specials.GetById(specialId);
            return new SpecialDto
            {
                Special = special
            };
        }

        public SpecialListDto GetAll()
        {
            var specials = _unitOfWork.Specials.GetList();
            return new SpecialListDto
            {
                Specials = specials
            };
        }

        public SpecialUpdateDto GetBySpecialEdit(int specialId)
        {
            var special = _unitOfWork.Specials.GetById(specialId);
            var specialUpdateDto = _mapper.Map<SpecialUpdateDto>(special);
            return specialUpdateDto;
          
        }

        public void Update(SpecialUpdateDto dto)
        {
            var specialEntity = _mapper.Map<Special>(dto);
            _unitOfWork.Specials.Update(specialEntity);
            _unitOfWork.SaveChanges();
        }
    }
}
