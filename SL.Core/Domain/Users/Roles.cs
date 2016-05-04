using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SL.Core.Domain.Users
{
    public class Roles
    {
        [Key]
        public long Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Users> Users { get; set; }
    }
}
