using System.ComponentModel.DataAnnotations;

namespace AppDomainLayer.Models.Cascade
{
    public class City
    {
        [Key]
        public int Id { get; set; }
        public string CityName { get; set; }
        public int StateId { get; set; }
        public State State { get; set; }
    }
}
