using Restaurantly.Entity.Dtos;
using Restaurantly.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurantly.Services.Abstract
{
    public interface IAboutService
    {
        AboutDto Get(int aboutId);
        AboutListDto GetAll();
        void Add(AboutAddDto dto);
        void Update(AboutUpdateDto dto);
        void Delete(int id);
    }
}
