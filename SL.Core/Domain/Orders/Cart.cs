using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SL.Core.Domain.Products;

namespace SL.Core.Domain.Orders
{
    public class Cart
    {
        [Key]
        public long Id { get; set; }
        public string CartId { get; set; }
        public int AlbumId { get; set; }
        public int Count { get; set; }
        public System.DateTime DateCreated { get; set; }
        public virtual Books Books { get; set; }
    }
}
