using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.Model.Models.Users
{
    public class Login
    {
        [Required]
        [DisplayName(@"Nick")]
        public string Username { get; set; }
        [Required]
        [DisplayName(@"Hasło")]
        public string Password { get; set; }
    }
}
