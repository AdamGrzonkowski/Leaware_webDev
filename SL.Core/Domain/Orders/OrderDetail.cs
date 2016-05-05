using System;
using System.Collections.Generic;
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
        public virtual Books Books { get; set; }
        public virtual Order Order { get; set; }
    }
}
