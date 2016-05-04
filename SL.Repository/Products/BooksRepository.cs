using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SL.Core.Interfaces.Repositories;
using SL.Model;
using SL.Repository._Base;

namespace SL.Repository.Products
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
