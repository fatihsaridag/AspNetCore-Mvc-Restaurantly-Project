using Microsoft.AspNetCore.Mvc;
using Restaurantly.Entity.Dtos;
using Restaurantly.Services.Abstract;

namespace Restaurantly.MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ChefController : Controller
    {
        private readonly IChefService _chefService;

        public ChefController(IChefService chefService)
        {
            _chefService = chefService;
        }


        public IActionResult ChefList()
        {
            var chefList = _chefService.GetAll();
            return View(chefList);
        }


        public IActionResult ChefEdit(int id)
        {
           var chef =  _chefService.GetByChefEdit(id);
            return View(chef);
        }


        [HttpPost]
        public IActionResult ChefEdit(ChefUpdateDto chefUpdateDto)
        {
            _chefService.Update(chefUpdateDto);
            return RedirectToAction("ChefList");
        }


        public IActionResult ChefDelete(int id)
        {
           _chefService.Delete(id);
            return RedirectToAction("ChefList");
        }

        [HttpGet]
        public IActionResult ChefAdd()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ChefAdd(ChefAddDto chefAddDto)
        {
            _chefService.Add(chefAddDto);
            return RedirectToAction("ChefList");
        }


    }
}
