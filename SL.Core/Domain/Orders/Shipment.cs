using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.Core.Domain.Orders
{
    public class Shipment
    {
        [Key]
        public long Id { get; set; }
        public string Method { get; set; }
        public decimal Price { get; set; }

    }
}
