using Microsoft.EntityFrameworkCore;
using Restaurantly.Data.EntityFramework.Contexts;
using Restaurantly.Data.EntityFramework.Repository.Abstract;
using Restaurantly.Entity.Entity;
using Restaurantly.Shared.Data.Repository.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurantly.Data.EntityFramework.Repository.Concrete
{
    public class EfTestimonialRepository : GenericRepository<Testimonial>, ITestimonialRepository
    {
        public EfTestimonialRepository(DbContext context) : base(context)
        {
        }

        public List<Testimonial> GetListWithTestimonialsByUser()
        {
            using(var context = new RestaurantlyContext())
            {
                return context.Testimonials.Include(x => x.AppUser).ToList();
            }
        }
    }
}
