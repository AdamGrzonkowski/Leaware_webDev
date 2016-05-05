using System.Collections.Generic;
using SL.Core.Domain.Products;

namespace SL.Core.Interfaces.Services.Products
{
    public interface IBooksService
    {
        List<Books> GetAllBooks();
        Books GetDetails(long? id);
        void Create(Books model);
    }
}
