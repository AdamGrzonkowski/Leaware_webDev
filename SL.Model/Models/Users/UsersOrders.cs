using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SL.Core.Domain.Orders;
using SL.Core.Domain.Products;

namespace SL.Model.Models.Users
{
    public class UsersOrders
    {
        [DisplayName(@"Id")]
        public long OrderId { get; set; }
        [DisplayName(@"Data zamówienia")]
        public System.DateTime OrderDate { get; set; }
        [DisplayName(@"Suma")]
        public decimal Total { get; set; }

        public string Status { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
        public string BookTitle { get; set; }

    }
}
