using Restaurantly.Entity.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurantly.Services.Abstract
{
    public interface ITestimonialService 
    {
        TestimonialDto Get(int aboutId);
        TestimonialListDto GetAll();
        void Add(TestimonialAddDto dto);
        void Update(TestimonialUpdateDto dto);
        void Delete(int id);
    }
}
