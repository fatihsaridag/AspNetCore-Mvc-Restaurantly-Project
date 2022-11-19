using Restaurantly.Data.Abstract;
using Restaurantly.Data.EntityFramework.Repository.Abstract;
using Restaurantly.Entity.Dtos;
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
        public ChefManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void Add(ChefAddDto dto)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public ChefDto Get(int aboutId)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }
    }
}
