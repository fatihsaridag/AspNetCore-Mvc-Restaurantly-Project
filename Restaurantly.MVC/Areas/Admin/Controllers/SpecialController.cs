using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Restaurantly.Entity.Dtos;
using Restaurantly.Services.Abstract;
using System;
using System.Data;
using System.IO;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Restaurantly.MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Adminn")]
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
        public async Task<IActionResult> SpecialEdit(SpecialUpdateDto specialUpdateDto, IFormFile picture)
        {
            if (ModelState.IsValid)
            {
                if (picture != null && picture.Length > 0)
                {
                    var fileName = Guid.NewGuid().ToString() + Path.GetExtension(picture.FileName);
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/SpecialPicture", fileName);
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await picture.CopyToAsync(stream);
                        specialUpdateDto.Picture = "/SpecialPicture/" + fileName;

                    }
                    _specialService.Update(specialUpdateDto);
                    return RedirectToAction("SpecialList");
                }
            }
            return View(specialUpdateDto);

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
        public async Task<IActionResult> SpecialAdd(SpecialAddDto specialAddDto,IFormFile picture)
        {

            if (ModelState.IsValid)
            {
                var fileName = Guid.NewGuid().ToString() + Path.GetExtension(picture.FileName);
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/SpecialPicture", fileName);
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await picture.CopyToAsync(stream);
                    specialAddDto.Picture = "/SpecialPicture/" + fileName;

                }
                _specialService.Add(specialAddDto);
                return RedirectToAction("SpecialList");
            }
            return View(specialAddDto);
        }

    }
}
