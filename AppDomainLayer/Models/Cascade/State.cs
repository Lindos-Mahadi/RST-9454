﻿using System.ComponentModel.DataAnnotations;

namespace AppDomainLayer.Models.Cascade
{
    public class State
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; }
    }
}
