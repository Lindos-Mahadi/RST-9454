﻿using System.ComponentModel.DataAnnotations;

namespace AppDomainLayer.Models.Account
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
    }
}
