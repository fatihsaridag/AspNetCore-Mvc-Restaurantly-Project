using AutoMapper;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
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
    public class MenuManager : IMenuService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public MenuManager(IUnitOfWork unitOfWork , IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public void Add(MenuAddDto dto)
        {
            var menuEntity = _mapper.Map<Menu>(dto);
            _unitOfWork.Menus.Add(menuEntity);
            _unitOfWork.SaveChanges();
        }

        public void Delete(int id)
        {
           var menu =  _unitOfWork.Menus.GetById(id);
            _unitOfWork.Menus.Delete(menu);
            _unitOfWork.SaveChanges();
        }

        public MenuDto Get(int menuId)
        {
            var menu = _unitOfWork.Menus.GetById(menuId);
            return new MenuDto
            {
                Menu = menu
            };
        }

        public MenuListDto GetAll()
        {
            var menus = _unitOfWork.Menus.GetList();
            return new MenuListDto
            {
                Menus = menus
            };
        }

        public MenuListDto GetListWithMenuByCategory()
        {
           var menuswithCategory = _unitOfWork.Menus.GetListWithMenuByCategory();
            return new MenuListDto
            {
                Menus = menuswithCategory
            };
        }

        public MenuUpdateDto GetUpdate(int menuId)
        {
            var menu = _unitOfWork.Menus.GetById(menuId);
            var menuUpdateDto = _mapper.Map<MenuUpdateDto>(menu); 
            return menuUpdateDto;
        }

        public void Update(MenuUpdateDto dto)
        {
           var menuEntity = _mapper.Map<Menu>(dto);
            _unitOfWork.Menus.Update(menuEntity);
            _unitOfWork.SaveChanges();
        }
    }
}
