using System.ComponentModel.DataAnnotations;

namespace AppDomainLayer.Models.Cascade
{
    public class Country
    {
        [Key]
        public int Id { get; set; }
        public string CountryName { get; set; }
    }
}
