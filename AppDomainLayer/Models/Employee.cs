﻿using System.ComponentModel.DataAnnotations;

namespace AppDomainLayer.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public decimal Country { get; set; }
    }
}