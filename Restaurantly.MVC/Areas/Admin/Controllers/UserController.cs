using AutoMapper;
using Mapster;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Restaurantly.Entity.Entity;
using Restaurantly.MVC.Areas.Admin.Models;
using Restaurantly.MVC.Models;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurantly.MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Adminn")]
    public class UserController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<AppRole> _roleManager;

        public UserController(UserManager<AppUser> userManager , RoleManager<AppRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public IActionResult UserList()
        {
            var userList = _userManager.Users.ToList();
            return View(userList);
        }

        [HttpGet]
        public IActionResult RoleCreate()
        {
            return View();
        }


        [HttpPost]
        public async Task<ActionResult> RoleCreate(RoleViewModel roleViewModel)
        {
            if (ModelState.IsValid)
            {
                AppRole role = new AppRole();
                role.Name = roleViewModel.Name;

                IdentityResult result = await _roleManager.CreateAsync(role);
                if (result.Succeeded)
                {
                    return RedirectToAction("RoleList");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }

            }
            return View(roleViewModel);
        }



        public IActionResult RoleList()
        {
            var roles = _roleManager.Roles.ToList();

            if (roles.Count == 0)
            {
                ViewBag.status = "true";
            }
            
            return View(roles);

        }

        public async Task<IActionResult> RoleDelete(string id)
        {
            AppRole role = await _roleManager.FindByIdAsync(id);

            if (role != null)
            {
               await _roleManager.DeleteAsync(role);
             
            }
            return RedirectToAction("RoleList");
        }


        [HttpGet]
        public async Task<IActionResult> RoleUpdate(string id)
        {
                AppRole role = await _roleManager.FindByIdAsync(id);
                 var roleViewModel = role.Adapt<RoleViewModel>();
                return View(roleViewModel);

        }



        [HttpPost]
        public async Task<IActionResult> RoleUpdate(RoleViewModel roleViewModel)
        {
                var role = await _roleManager.FindByIdAsync(roleViewModel.Id);
                role.Name = roleViewModel.Name;
                IdentityResult result =  await _roleManager.UpdateAsync(role);
                if (result.Succeeded)
                {
                    return RedirectToAction("RoleList");
                }

            return View(roleViewModel);

        }


        [HttpGet]
        public async Task<IActionResult> RoleAssign(string id)
        {
            TempData["userId"] = id;
            var user = await _userManager.FindByIdAsync(id);                        //Id ye göre kullanıcıyı getiriyoruz.
            ViewBag.userName = user.UserName;                                       // Bu username yi view tarafına yazıcaz

            var roles = _roleManager.Roles;                                         //Rolleri çektik
            var userRoles = await _userManager.GetRolesAsync(user) as List<string>;  //Tıklamış olduğumuz kullanıcı hangi rollere saghip bunu List<string> olarak bize dönecek.
            var roleAssignViewModels = new List<RoleAssignViewModel>();              //RoleAssignViewModelden bir liste alıyoruz.

            foreach (var role in roles)                                               //
            {
                RoleAssignViewModel r = new RoleAssignViewModel();                    //Checkboxun işaretli olup olmadıgını bilmek içinn bir viewmodel yazdık ve doldurduk içini
                r.RoleId = role.Id.ToString();                                                  //viewmodel id içerisine at 
                r.RoleName = role.Name;                                              //viewmodel name içerisine at 
                if (userRoles.Contains(role.Name))                                   // Eğer kullanıcı rollerin içerisinde  bu kullanıcı var mı eğer var ise
                {
                    r.Exist = true;                                                  //Checkboxu işaretle
                }
                else
                {
                    r.Exist = false;                                                  //Yok ise chechboxu işaretleme
                }
                roleAssignViewModels.Add(r);
            }

            return View(roleAssignViewModels);
        }


        [HttpPost]
        public async Task<IActionResult> RoleAssign(List<RoleAssignViewModel> roleAssignViewModels)
        {
            var user = await _userManager.FindByIdAsync(TempData["userId"].ToString());     // TempDatada Get metodunda atayacağımız kullanıcıyı bulmak için id yi yakaladık ve kullanıcıyı bulduk
            foreach (var item in roleAssignViewModels)                                       //Listeyi foreach ile döndük                 
            {
                if (item.Exist)                                                             //Eğer checkboxa tıklanmış ise biz bu rolü atayalım
                {
                    await _userManager.AddToRoleAsync(user, item.RoleName);                  //1. Parametre user , 2. parametre rol adı
                }
                else
                {
                    await _userManager.RemoveFromRoleAsync(user, item.RoleName);            //Eğer checkbox işaretli değil ise bu rolü kaldırdık.
                }
            }

            return RedirectToAction("UserList");                                               //Bu işlemler bitince "Users" sayfasına dön
        }

    }
}
