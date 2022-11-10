using Restaurantly.Entity.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurantly.Services.Abstract
{
    public interface ISpecialService
    {
        SpecialDto Get(int aboutId);
        SpecialListDto GetAll();
        void Add(SpecialAddDto dto);
        void Update(SpecialUpdateDto dto);
        void Delete(int id);
    }
}
