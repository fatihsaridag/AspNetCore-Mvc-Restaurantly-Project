using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Restaurantly.Entity.Dtos;
using Restaurantly.Entity.Entity;
using Restaurantly.Services.Abstract;
using System.Threading.Tasks;

namespace Restaurantly.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAboutService _aboutService;
        private readonly IMenuService _menuService;
        private readonly ISpecialService _specialService;
        private readonly IReservationService _reservationService;
        private readonly ITestimonialService _testimonialService;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly UserManager<AppUser> _userManager;


        public HomeController(IAboutService aboutService, IMenuService menuService, ISpecialService specialService, IReservationService reservationService, ITestimonialService testimonialService,SignInManager<AppUser> signInManager , UserManager<AppUser> userManager)
        {
            _aboutService = aboutService;
            _menuService = menuService;
            _specialService = specialService;
            _reservationService = reservationService;
            _testimonialService = testimonialService;
            _testimonialService = testimonialService;
            _signInManager = signInManager;
            _userManager= userManager;
        }
        public IActionResult Index()
        {
            return View();
        }

        
        public IActionResult About()
        {
            var abouts = _aboutService.GetAll();
            return View(abouts);
        }

        public IActionResult MenuList()
        {
            var menuList = _menuService.GetAll();
            return View(menuList);
        }

        public IActionResult SpecialList()
        {
            var specialListDto = _specialService.GetAll();
            return View(specialListDto);
        }


        [HttpGet]
        public IActionResult Reservation()
        {
            return View(); 
        }

        [HttpPost]
        public IActionResult Reservation(ReservationAddDto reservationAddDto)
        {
           
                _reservationService.Add(reservationAddDto);
                 return View(reservationAddDto);
        }

        public IActionResult Testimonials()
        {
            var values = _testimonialService.GetListWithTestimonialsByUser();
            return View(values);
        }

    }
}
