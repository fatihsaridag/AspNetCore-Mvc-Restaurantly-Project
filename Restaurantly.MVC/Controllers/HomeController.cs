using Microsoft.AspNetCore.Mvc;
using Restaurantly.Services.Abstract;

namespace Restaurantly.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAboutService _aboutService;
        public HomeController(IAboutService aboutService)
        {
            _aboutService = aboutService;
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
    }
}
