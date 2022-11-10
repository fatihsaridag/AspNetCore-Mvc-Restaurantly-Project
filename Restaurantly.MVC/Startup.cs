using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Restaurantly.Data.Abstract;
using Restaurantly.Data.Concrete;
using Restaurantly.Data.EntityFramework.Contexts;
using Restaurantly.Services.Abstract;
using Restaurantly.Services.AutoMapper.Profiles;
using Restaurantly.Services.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurantly.MVC
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<RestaurantlyContext>();
            services.AddControllersWithViews();
            services.AddRazorPages();
            services.AddAutoMapper(typeof(AboutProfile),typeof(ReservationProfile));
            services.AddMvc();
            services.AddScoped<IUnitOfWork,UnitOfWork>();
            services.AddScoped<IMenuService,MenuManager>();
            services.AddScoped<IAboutService, AboutManager>();
            services.AddScoped<ISpecialService, SpecialManager>();
            services.AddScoped<IReservationService, ReservationManager>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapRazorPages();
            //});
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
