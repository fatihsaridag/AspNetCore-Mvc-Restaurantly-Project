using Microsoft.AspNetCore.Mvc;
using Restaurantly.Entity.Dtos;
using Restaurantly.Services.Abstract;

namespace Restaurantly.MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SpecialController : Controller
    {
        private readonly ISpecialService _specialService;


        public SpecialController(ISpecialService specialService)
        {
            _specialService = specialService;
        }

        public IActionResult SpecialList()
        {
           var specials =  _specialService.GetAll();
            return View(specials);
        }


        [HttpGet]
        public IActionResult SpecialEdit(int id)
        {
            var special = _specialService.GetBySpecialEdit(id);
            return View(special);
        }



        [HttpPost]
        public IActionResult SpecialEdit(SpecialUpdateDto specialUpdateDto)
        {
            _specialService.Update(specialUpdateDto);
            return RedirectToAction("SpecialList");
        }


        public IActionResult SpecialDelete(int id)
        {
            _specialService.Delete(id);
            return RedirectToAction("SpecialList");
        }



        [HttpGet]
        public IActionResult SpecialAdd()
        {
            return View();
        }


        [HttpPost]
        public IActionResult SpecialAdd(SpecialAddDto specialAddDto)
        {
            _specialService.Add(specialAddDto);
            return RedirectToAction("SpecialList");
        }

    }
}
