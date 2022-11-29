using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Restaurantly.Entity.Dtos;
using Restaurantly.Entity.Entity;
using Restaurantly.Services.Abstract;
using System;
using System.Data;
using System.IO;
using System.Threading.Tasks;

namespace Restaurantly.MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Adminn")]
    public class MenuController : Controller
    {
        private readonly IMenuService _menuService;
        private readonly UserManager<AppUser> _userManager;

        public MenuController(IMenuService menuService,UserManager<AppUser> userManager)
        {
            _menuService = menuService;
            _userManager = userManager;
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
        public async Task<IActionResult> MenuEdit(MenuUpdateDto menuUpdateDto, IFormFile picture)
        {
            if (ModelState.IsValid)
            {
                if (picture != null && picture.Length > 0)
                {
                    var fileName = Guid.NewGuid().ToString() + Path.GetExtension(picture.FileName);
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/MenuPicture", fileName);
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await picture.CopyToAsync(stream);
                        menuUpdateDto.Picture = "/MenuPicture/" + fileName;
                    }
                    _menuService.Update(menuUpdateDto);
                    return RedirectToAction("MenuList");
                }
                    ModelState.AddModelError("", "Böyle bir resim bulunmamaktadır.");
            }
            return View(menuUpdateDto);
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
        public async Task<IActionResult> MenuAdd(MenuAddDto menuAddDto, IFormFile picture)
        {
            if (ModelState.IsValid)
            {
                var fileName = Guid.NewGuid().ToString() + Path.GetExtension(picture.FileName);
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/MenuPicture", fileName);
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await picture.CopyToAsync(stream);
                    menuAddDto.Picture = "/MenuPicture/" + fileName;
                }
                _menuService.Add(menuAddDto);
                return RedirectToAction("MenuList");
            }
            return View(menuAddDto);
        }
    }
}
