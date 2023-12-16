using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AppDomainLayer.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("Employee Name")]
        public string Name { get; set; }
        [Required]
        [DisplayName("Employee Gender")]
        public string Gender { get; set; }
        [Required]
        [DisplayName("Employee Email")]
        public string Email { get; set; }
        [Required]
        [DisplayName("Employee Country")]
        public string Country { get; set; }
    }
}
