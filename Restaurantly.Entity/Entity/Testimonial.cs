using Restaurantly.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurantly.Entity.Entity
{
    public class Testimonial : EntityBase
    {
        [Key]
        public int Id { get; set; }
        public string Description { get; set; }
        public int UserId { get; set; }
        public AppUser AppUser { get; set; }
    }
}
