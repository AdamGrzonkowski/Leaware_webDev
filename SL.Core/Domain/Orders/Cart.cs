﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        public string Identifier { get; set; }
        public long BookId { get; set; }
        public int Count { get; set; }
        public System.DateTime DateCreated { get; set; }
        [ForeignKey("BookId")]
        public virtual Books Books { get; set; }
    }
}
