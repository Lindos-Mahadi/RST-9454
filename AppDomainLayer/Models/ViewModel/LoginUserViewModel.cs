using System.ComponentModel.DataAnnotations;

namespace AppDomainLayer.Models.ViewModel
{
    public class LoginUserViewModel
    {
        [Required]
        [Display(Name = "User Name")]
        public string UserName { get; set; }
        [Required]
        [Display(Name = "User Password")]
        public string Password { get; set; }
        [Display(Name = "Remember Me?")]
        public bool IsRemember { get; set; }
    }
}
