using Restaurantly.Entity.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurantly.Services.Abstract
{
    public interface IChefService
    {
        ChefDto Get(int aboutId);
        ChefListDto GetAll();
        void Add(ChefAddDto dto);
        void Update(ChefUpdateDto dto);
        ChefUpdateDto GetByChefEdit(int id);
        void Delete(int id);
    }
}
