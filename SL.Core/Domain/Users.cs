using System.ComponentModel.DataAnnotations;

namespace SL.Core.Domain
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
        
    }
}
