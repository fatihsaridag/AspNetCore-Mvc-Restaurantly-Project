using Restaurantly.Data.EntityFramework.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurantly.Data.Abstract
{
    public interface IUnitOfWork : IDisposable
    {
        IAboutRepository Abouts { get; }
        ICategoryRepository Categories { get; }
        IChefRepository Chefs { get; }
        IReservationRepository Reservations { get; }
        ISpecialRepository Specials { get; }
        ITestimonialRepository Testimonials { get; }
        IMenuRepository Menus { get; }
        IContactRepository Contacts { get; }

        int SaveChanges();
    }
}
