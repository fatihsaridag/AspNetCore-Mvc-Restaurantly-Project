using AutoMapper;
using Restaurantly.Data.Abstract;
using Restaurantly.Entity.Dtos;
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
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public SpecialDto Get(int aboutId)
        {
            throw new NotImplementedException();
        }

        public SpecialListDto GetAll()
        {
            var specials = _unitOfWork.Specials.GetList();
            return new SpecialListDto
            {
                Specials = specials
            };
        }

        public void Update(SpecialUpdateDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
