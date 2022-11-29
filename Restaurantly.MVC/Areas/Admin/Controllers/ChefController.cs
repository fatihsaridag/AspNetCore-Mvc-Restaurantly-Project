using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Restaurantly.Entity.Dtos;
using Restaurantly.Entity.Entity;
using Restaurantly.Services.Abstract;
using System;
using System.IO;
using System.Threading.Tasks;

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
            if (chefList.Chefs.Count > 3 || chefList.Chefs.Count == 3)
            {
                ViewBag.status = "true";
            }
            else
            {
                ViewBag.status = "false";
            }
            return View(chefList);

        }


        public IActionResult ChefEdit(int id)
        {
           var chef =  _chefService.GetByChefEdit(id);
            return View(chef);
        }


        [HttpPost]
        public async Task<IActionResult> ChefEdit(ChefUpdateDto chefUpdateDto, IFormFile picture)
        {
            if (ModelState.IsValid)
            {
                if (picture != null && picture.Length > 0)
                {
                    var fileName = Guid.NewGuid().ToString() + Path.GetExtension(picture.FileName);
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/ChefPicture", fileName);
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await picture.CopyToAsync(stream);
                        chefUpdateDto.Picture = "/ChefPicture/" + fileName;
                    }
                    _chefService.Update(chefUpdateDto);
                    return RedirectToAction("ChefList");
                }
            }
            return View(chefUpdateDto);
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
        public async Task<IActionResult> ChefAdd(ChefAddDto chefAddDto, IFormFile picture)
        {
            var chefList = _chefService.GetAll();

            if (ModelState.IsValid)
            {
                    var fileName = Guid.NewGuid().ToString() + Path.GetExtension(picture.FileName);

                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/ChefPicture", fileName);
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await picture.CopyToAsync(stream);
                        chefAddDto.Picture = "/ChefPicture/" + fileName;
                    }
                    _chefService.Add(chefAddDto);
                    ViewBag.success = "true";
                    return RedirectToAction("ChefList");
            }
            return View(chefAddDto);
        }


    }
}
