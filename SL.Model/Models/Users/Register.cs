﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.Model.Models.Users
{
    public class Register
    {
        [EmailAddress]
        [Required]
        public string Email { get; set; }
        [Required]
        [DisplayName(@"Nick")]
        public string Username { get; set; }
        [Required]
        [DisplayName(@"Hasło")]
        [StringLength(32, ErrorMessageResourceType = typeof(ModelResources), ErrorMessageResourceName = "PasswordValidationMsg", MinimumLength = 5)]
        public string Password { get; set; }

        [Required]
        [DisplayName(@"Potwierdź hasło")]
        [StringLength(32, ErrorMessageResourceType = typeof(ModelResources), ErrorMessageResourceName = "PasswordValidationMsg", MinimumLength = 5)]
        [Compare("Password", ErrorMessageResourceType = typeof(ModelResources), ErrorMessageResourceName = "PasswordConfirmValidation")]
        public string ConfirmPassword { get; set; }
    }
}
