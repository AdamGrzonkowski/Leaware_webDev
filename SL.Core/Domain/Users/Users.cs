using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SL.Core.Domain.Users
{
    public class Users
    {
        [Key]
        public long Id { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Salt { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
        public virtual ICollection<Roles> Roles { get; set; }

    }
}
