using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Restaurantly.Entity.Dtos;
using Restaurantly.Services.Abstract;

namespace Restaurantly.MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles ="Adminn")]
    public class AboutController : Controller
    {
        private readonly IAboutService _aboutService;

        public AboutController(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }


        public IActionResult AboutList()
        {
            var aboutListDto = _aboutService.GetAll();
            return View(aboutListDto);
        }


        [HttpGet]
        public IActionResult AboutEdit(int id)
        {
            var about = _aboutService.GetbyAboutEdit(id);
            return View(about);
        }


        [HttpPost]
        public IActionResult AboutEdit(AboutUpdateDto aboutUpdateDto)
        {
            _aboutService.Update(aboutUpdateDto);
            return RedirectToAction("AboutList");
        }


    }
}
