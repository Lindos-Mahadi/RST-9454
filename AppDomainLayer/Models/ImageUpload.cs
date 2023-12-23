using System.ComponentModel.DataAnnotations;

namespace AppDomainLayer.Models
{
    public class ImageUpload
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImagePath { get; set; }
    }
}
