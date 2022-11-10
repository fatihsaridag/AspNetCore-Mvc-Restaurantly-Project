using Restaurantly.Entity.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurantly.Services.Abstract
{
    public  interface IMenuService
    {
        MenuDto Get(int aboutId);
        MenuListDto GetAll();
        void Add(MenuAddDto dto);
        void Update(MenuUpdateDto dto);
        void Delete(int id);
    }
}
