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
    public class MenuManager : IMenuService
    {
        private readonly IUnitOfWork _unitOfWork;
        public MenuManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public void Add(MenuAddDto dto)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public MenuDto Get(int aboutId)
        {
            throw new NotImplementedException();
        }

        public MenuListDto GetAll()
        {
            var menus = _unitOfWork.Menus.GetList();
            return new MenuListDto
            {
                Menus= menus
            };
        }

        public void Update(MenuUpdateDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
