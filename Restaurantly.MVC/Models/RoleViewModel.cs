using System.ComponentModel.DataAnnotations;

namespace Restaurantly.MVC.Models
{
    public class RoleViewModel
    {
        [Display(Name="Rol İsmi")]
        [Required(ErrorMessage ="Role ismi gereklidir.")]
        public string Name { get; set; }

        public string Id { get; set; } //Rol güncellemek için bir Id ye ihtiyacımız var. 


    }
}
