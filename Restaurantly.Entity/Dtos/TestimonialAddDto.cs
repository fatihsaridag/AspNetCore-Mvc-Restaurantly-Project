using Restaurantly.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurantly.Entity.Dtos
{
    public class TestimonialAddDto
    {
        public string Description { get; set; }
        public string Image { get; set; }
        public string Job { get; set; }
        public int UserId { get; set; }
        public AppUser AppUser { get; set; }
    }
}
