using System.ComponentModel.DataAnnotations;

namespace AppDomainLayer.Models.Account
{
    public class SignUpUserViewModel
    {
        //public int Id { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Email { get; set; }
        public long Mobile { get; set; }
        [Required]
        public string Password { get; set; }
        public bool IsActive { get; set; }
        //public bool IsRemember { get; set; }
    }
}
