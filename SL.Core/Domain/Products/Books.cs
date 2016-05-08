using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SL.Core.Domain.Products
{
    public class Books
    {
        [Key]
        public long Id { get; set; }
        [Display(Name = "Tytuł")]
        public string Title { get; set; }
        [Display(Name = "Cena")]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
        [Display(Name = "Autor")]
        public string Author { get; set; }
        [Display(Name = "Data wydania")]
        [DataType(DataType.Date)]
        public DateTime DateReleased { get; set; }
    }
}
