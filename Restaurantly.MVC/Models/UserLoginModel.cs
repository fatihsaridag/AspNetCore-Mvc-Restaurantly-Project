using System;
using System.ComponentModel.DataAnnotations;

namespace Restaurantly.MVC.Models
{
    public class UserLoginModel
    {

        [Display(Name = "Kullanıcı Adınız")]
        [Required(ErrorMessage = "Kulllanıcı adınız gereklidir")]
        public string UserName { get; set; }

        [Display(Name = "Şifreniz")]
        [Required(ErrorMessage = "Şire alanınız gereklidir.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

    }
}
