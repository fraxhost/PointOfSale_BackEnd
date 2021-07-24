﻿using System.ComponentModel.DataAnnotations;

namespace API.Dtos
{
    public class RegistrationDto
    {
        [Required]
        public string UserName { get; set; }
        
        [Required(ErrorMessage = "Password is required!")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }
}
