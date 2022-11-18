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
    public class TestimonialManager : ITestimonialService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public TestimonialManager(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public void Add(TestimonialAddDto dto)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public TestimonialDto Get(int aboutId)
        {
            throw new NotImplementedException();
        }

        public TestimonialListDto GetAll()
        {
            var testimonials = _unitOfWork.Testimonials.GetList();
            return new TestimonialListDto
            {
                Testimonials = testimonials
            };
        }

        public TestimonialListDto GetListWithTestimonialsByUser()
        {
            var testimonials = _unitOfWork.Testimonials.GetListWithTestimonialsByUser();
            return new TestimonialListDto
            {
                Testimonials = testimonials
            };
        }

        public void Update(TestimonialUpdateDto dto)
        {
            throw new NotImplementedException();
        }
    }

}

