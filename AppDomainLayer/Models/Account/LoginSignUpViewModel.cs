using System.ComponentModel.DataAnnotations;

namespace AppDomainLayer.Models.Account
{
    public class LoginSignUpViewModel
    {
        //public int Id { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }

        public bool IsRemember { get; set; }
    }
}
