using Restaurantly.Data.Abstract;
using Restaurantly.Data.EntityFramework.Contexts;
using Restaurantly.Data.EntityFramework.Repository.Abstract;
using Restaurantly.Data.EntityFramework.Repository.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurantly.Data.Concrete
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly RestaurantlyContext _context;
        private EfAboutRepository _aboutRepository;
        private EfCategoryRepository _categoryRepository;
        private EfChefRepository _chefRepository;
        private EfContactRepository _contactRepository;
        private EfMenuRepository _menuRepository;
        private EfReservationRepository _reservationRepository;
        private EfSpecialRepository _specialRepository;
        private EfTestimonialRepository _testimonialRepository;


        public UnitOfWork(RestaurantlyContext context)
        {
            _context = context;
        }


        public IAboutRepository Abouts => _aboutRepository ?? new EfAboutRepository(_context);

        public ICategoryRepository Categories => _categoryRepository ?? new EfCategoryRepository(_context);

        public IChefRepository Chefs => _chefRepository ?? new EfChefRepository(_context);

        public IReservationRepository Reservations => _reservationRepository ?? new EfReservationRepository(_context);

        public ISpecialRepository Specials => _specialRepository ?? new EfSpecialRepository(_context);

        public ITestimonialRepository Testimonials => _testimonialRepository ?? new EfTestimonialRepository(_context);

        public IMenuRepository Menus => _menuRepository ?? new EfMenuRepository(_context);

        public IContactRepository Contacts => _contactRepository ?? new EfContactRepository(_context);

        public void Dispose()
        {
            _context.Dispose();
        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }
    }
}
