using Restaurantly.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurantly.Entity.Dtos
{
    public class HomeListDto
    {
        public List<About> Abouts { get; set; }
        public List<Menu> Menus { get; set; }
        public List<Special> Specials { get; set; }
        public List<Testimonial> Testimonials { get; set; }
        public List<Chef> Chefs { get; set; }
    }
}
