using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppDomainLayer.Models.ViewModel
{
    public class ImageUploadViewModel
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Please enter name")]
        public string Name { get; set; }
        [NotMapped]
        [Required(ErrorMessage ="Please choose Image/File")]
        [Display(Name ="Upload Image/File")]
        public IFormFile ImageFile { get; set; }
    }
}
