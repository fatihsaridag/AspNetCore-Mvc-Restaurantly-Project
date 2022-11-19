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
    public class HomeManager : IHomeService
    {
        private readonly IUnitOfWork _unitOfWork;

        public HomeManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public HomeListDto GetAll()
        {
            var abouts = _unitOfWork.Abouts.GetList();
            var menus = _unitOfWork.Menus.GetList();
            var specials = _unitOfWork.Specials.GetList();
            var testimonials = _unitOfWork.Testimonials.GetListWithTestimonialsByUser();
            var chefs = _unitOfWork.Chefs.GetList();

            return new HomeListDto
            {
                Abouts = abouts,
                Menus = menus,
                Specials = specials,
                Testimonials = testimonials,
                Chefs = chefs
            };

        }
    }
}
