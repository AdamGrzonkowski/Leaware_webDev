using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SL.Core.Domain.Products;

namespace SL.Core.Interfaces.Services
{
    public interface IBooksService
    {
        List<Books> GetAllBooks();
        Books GetDetails(long? id);
        void Create(Books model);
    }
}
