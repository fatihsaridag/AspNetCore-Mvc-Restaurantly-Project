using System.ComponentModel.DataAnnotations;

namespace Restaurantly.MVC.Models
{
    public class PasswordResetViewModel
    {
        [Required(ErrorMessage ="Lütfen Email Adresinizi giriniz")]
        [Display(Name ="Emailiniz")]
        [EmailAddress(ErrorMessage ="Email adresinizi doğru formatta giriniz")]
        public string Email { get; set; }


        [Required(ErrorMessage = "Lütfen Şifrenizi doğru giriniz")]
        [Display(Name="Yeni Şifreniz")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
