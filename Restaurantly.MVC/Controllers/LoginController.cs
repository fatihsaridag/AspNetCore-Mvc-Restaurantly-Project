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
                        return RedirectToAction("SignIn", "Login");
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

        public IActionResult LogOut()
        {
            _signInManager.SignOutAsync();
            return RedirectToAction("SignIn", "Login");
        }


        [HttpGet]
        public IActionResult ResetPassword()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> ResetPassword(PasswordResetViewModel passwordResetViewModel)
        {
            AppUser user = await _userManager.FindByEmailAsync(passwordResetViewModel.Email);

            if (user != null)
            {
                //Artık token oluşturabiliriz. 
                string passwordResetToken = _userManager.GeneratePasswordResetTokenAsync(user).Result;
                //Linki burada gönderiyoruz kullanıcı linke tıklayınca bu url e gidecek:

                string passwordResetLink = Url.Action("ResetPasswordConfirm", "Login", new  //Burada obje olarak querystring değerlerimizi veriyoruz. 
                {
                    userId = user.Id,
                    token = passwordResetToken
                }, HttpContext.Request.Scheme);

                Helper.PasswordReset.PassowrdResetSendEmail(passwordResetLink, user.Email);
                ViewBag.status = "success";

            }
            else
            {
                ModelState.AddModelError("", "Sistemde kayıtlı email adresi bulunamamıştır");
            }

            return View(passwordResetViewModel);
        }


        //Oluşturmuş oldugumuz queryStrink linkinden bu değerleri yakalıyoruz.
        [HttpGet]
        public IActionResult ResetPasswordConfirm(string userId , string token)
        {
            TempData["userId"] = userId;
            TempData["token"] = token;
            return View();
        }



        [HttpPost]
        public async Task<IActionResult> ResetPasswordConfirm([Bind("Password")] PasswordResetViewModel passwordResetViewModel)
        {
            string token = TempData["token"].ToString();
            string userId = TempData["userId"].ToString();

            AppUser user = await _userManager.FindByIdAsync(userId);
            if (user != null)
            {
                IdentityResult result = await _userManager.ResetPasswordAsync(user, token, passwordResetViewModel.Password);
                if (result.Succeeded)
                {
                    await _userManager.UpdateSecurityStampAsync(user);
                    TempData["passwordResetInfo"] = "Şifreniz başarıyla yenilenmiştir. Yeni şifre ile giriş yapabilirsiniz.";
                    ViewBag.status = "success"; 
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
            }

            else
            {
                ModelState.AddModelError("", "Hata meydana gelmiştir lüften daha sonra tekrar deneyin");
            }
            return View(passwordResetViewModel);
        }
    }
}
