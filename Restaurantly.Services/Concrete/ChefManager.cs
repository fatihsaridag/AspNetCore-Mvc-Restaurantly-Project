using AutoMapper;
using Restaurantly.Data.Abstract;
using Restaurantly.Data.EntityFramework.Repository.Abstract;
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
    public class ChefManager : IChefService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ChefManager(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public void Add(ChefAddDto dto)
        {
           var chefEntity =  _mapper.Map<Chef>(dto);
            _unitOfWork.Chefs.Add(chefEntity);
            _unitOfWork.SaveChanges();
        }

        public void Delete(int id)
        {
            var chef = _unitOfWork.Chefs.GetById(id);
            _unitOfWork.Chefs.Delete(chef);
            _unitOfWork.SaveChanges();
        }

        public ChefDto Get(int aboutId)
        {
            var chefEntity = _unitOfWork.Chefs.GetById(aboutId);
            return new ChefDto
            {
                Chef = chefEntity
            };
        }




        public ChefListDto GetAll()
        {
            var chefList = _unitOfWork.Chefs.GetList();
            return new ChefListDto
            {
                Chefs = chefList
            };
        }

        public void Update(ChefUpdateDto dto)
        {
            var chefUpdateDto = _mapper.Map<Chef>(dto);
            _unitOfWork.Chefs.Update(chefUpdateDto);
            _unitOfWork.SaveChanges();
        }

        public ChefUpdateDto GetByChefEdit(int id)
        {
            var chef = _unitOfWork.Chefs.GetById(id);
            var chefUpdateDto = _mapper.Map<ChefUpdateDto>(chef);
            return chefUpdateDto;
        }
    }
}
