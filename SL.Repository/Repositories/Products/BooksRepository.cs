using SL.Core.Interfaces.Repositories;
using SL.Core.Interfaces.Repositories.Products;
using SL.Model;
using SL.Repository.Repositories._Base;

namespace SL.Repository.Repositories.Products
{
    public class BooksRepository : Repository<Core.Domain.Products.Books>, IBooksRepository
    {
        public BooksRepository(ApplicationDbContext context) : base(context)
        {
        }

        public ApplicationDbContext DbContext
        {
            get { return Context as ApplicationDbContext; }
        }
    }
}
