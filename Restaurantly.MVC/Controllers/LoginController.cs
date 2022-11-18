using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Restaurantly.Entity.Entity;
using Restaurantly.MVC.Models;
using System.Threading.Tasks;

namespace Restaurantly.MVC.Controllers
{
    public class LoginController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        public LoginController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SignUp(UserRegisterModel userRegisterModel)
        {
            if (ModelState.IsValid)
            {
                AppUser appuser = new AppUser();
                appuser.UserName = userRegisterModel.UserName;
                appuser.Email = userRegisterModel.Email;
                appuser.PhoneNumber = userRegisterModel.PhoneNumber;


                if (userRegisterModel.Password == userRegisterModel.ConfirmPassword)
                {
                    IdentityResult result = await _userManager.CreateAsync(appuser, userRegisterModel.Password);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("SignIn");
                    }
                    else
                    {
                        foreach (var item in result.Errors)
                        {
                            ModelState.AddModelError("", item.Description);
                        }
                    }

                }
                return View(userRegisterModel);

            }
            return View(userRegisterModel);
        }


        [HttpGet]
        public IActionResult SignIn()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> SignIn(UserLoginModel userLoginModel)
        {
            if (ModelState.IsValid)
            {

                AppUser user = await _userManager.FindByNameAsync(userLoginModel.UserName);
                if (user != null)
                {
                    await _signInManager.SignOutAsync();
                    var result = await _signInManager.PasswordSignInAsync(user, userLoginModel.Password,false, false);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        return View("SignIn", "Login");
                    }

                }
                else
                {
                    ModelState.AddModelError(nameof(userLoginModel.UserName), "Geçersiz kullanıcı adı veya şifresi");
                }


                //var result = await _signInManager.PasswordSignInAsync(userLoginModel.UserName, userLoginModel.Password, false, true);
                //if (result.Succeeded)
                //{
                //    return RedirectToAction("Index","Home");
                //}
                //else
                //{
                //    return View("SignIn", "Login");
                //}
            }
            return View(userLoginModel);
        }

        public async Task<IActionResult> SignOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

    }
}
