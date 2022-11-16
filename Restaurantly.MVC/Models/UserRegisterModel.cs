using System.ComponentModel.DataAnnotations;

namespace Restaurantly.MVC.Models
{
 
    public class UserRegisterModel
    {
        [Required(ErrorMessage = "Lütfen Adınızı Giriniz ")]
        [Display(Name = "Adınız")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Lütfen Soyadınızı Giriniz ")]
        [Display(Name = "Soyadınız")]
        public string SurName { get; set; }

        [Required(ErrorMessage = "Kullanıcı adınız gereklidir.")]
        [Display(Name = "Kullanıcı Adı")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Email Adresiniz gereklidir.")]
        [Display(Name = "Email Adresi")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Telefon numaranız gereklidir")]
        [Display(Name = "Telefon Numarası")]
        public string PhoneNumber { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Şifreniz gereklidir.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Şifre Tekrar alanı gereklidir")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Şifreler uyumlu değil")]
        public string ConfirmPassword { get; set; }


      
    }
}
