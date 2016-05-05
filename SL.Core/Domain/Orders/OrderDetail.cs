using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SL.Core.Domain.Products;

namespace SL.Core.Domain.Orders
{
    public class OrderDetail
    {
        public long OrderDetailId { get; set; }
        public long OrderId { get; set; }
        public long BookId { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        [ForeignKey("BookId")]
        public virtual Books Books { get; set; }
        [ForeignKey("OrderId")]
        public virtual Order Order { get; set; }
    }
}
