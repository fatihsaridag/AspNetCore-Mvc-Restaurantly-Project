using Microsoft.AspNetCore.Mvc;
using Restaurantly.Entity.Dtos;
using Restaurantly.Services.Abstract;

namespace Restaurantly.MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MenuController : Controller
    {
        private readonly IMenuService _menuService;

        public MenuController(IMenuService menuService)
        {
            _menuService = menuService;
        }
        public IActionResult MenuList()
        {
            var menuList = _menuService.GetListWithMenuByCategory();
            return View(menuList);
        }

        [HttpGet]
        public IActionResult MenuEdit(int id)
        {
           var menu =  _menuService.GetUpdate(id);
            return View(menu);
        }


        [HttpPost]
        public IActionResult MenuEdit(MenuUpdateDto menuUpdateDto)
        {
            _menuService.Update(menuUpdateDto);
            return RedirectToAction("MenuList");
        }

        public IActionResult MenuDelete(int id)
        {
            _menuService.Delete(id);
            return RedirectToAction("MenuList");
        }

        [HttpGet]
        public IActionResult MenuAdd()
        {
            return View();
        }

        [HttpPost]
        public IActionResult MenuAdd(MenuAddDto menuAddDto)
        {
            _menuService.Add(menuAddDto);
            return RedirectToAction("MenuList");
        }


    }
}
