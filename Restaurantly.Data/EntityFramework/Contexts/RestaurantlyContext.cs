using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Restaurantly.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurantly.Data.EntityFramework.Contexts
{
    public class RestaurantlyContext : IdentityDbContext<AppUser,AppRole,int>
    {
        public DbSet<About> Abouts{ get; set; }
        public DbSet<Category> Categories{ get; set; }
        public DbSet<Chef> Chefs{ get; set; }
        public DbSet<Contact> Contacts{ get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Reservation> Reservations{ get; set; }
        public DbSet<Special> Specials{ get; set; }
        public DbSet<Testimonial> Testimonials{ get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=(localdb)\\MSSQLLocalDB; database=Restaurantly;integrated security=true;");
        }


    }
}
