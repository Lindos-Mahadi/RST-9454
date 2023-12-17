using System.ComponentModel.DataAnnotations;

namespace AppDomainLayer.Models.ViewModel
{
    public class SignUpUserViewModel
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter user name")]
        [Display(Name ="User Name")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Please enter email")]
        [RegularExpression(@"^([0-9a-zA-Z]([-\.\'\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z\.])+[.a-zA-Z]{2,9})$", ErrorMessage ="Please enter valid Email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please enter mobile")]
        [RegularExpression(@"^\+?\d{1,4}-?\d{10}$", ErrorMessage = "Invalid phone number")]
        public string Mobile { get; set; }
        [Required(ErrorMessage = "Please enter password")]
        [Display(Name = "User Password")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Please enter confirm password")]
        [Display(Name = "Confirm Password")]
        [Compare("Password", ErrorMessage ="Password can not be matched!")]
        public string ConfirmPassword { get; set; }
        public bool IsActive { get; set; }
    }
}
