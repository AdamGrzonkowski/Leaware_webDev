using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SL.Core.Interfaces.Repositories.Orders;
using SL.Model;
using SL.Repository.Repositories._Base;

namespace SL.Repository.Repositories.Orders
{
    public class CartRepository : Repository<Core.Domain.Orders.Cart>, ICartRepository
    {
        public CartRepository(ApplicationDbContext context) : base(context)
        {
        }

        public ApplicationDbContext DbContext
        {
            get { return Context as ApplicationDbContext; }
        }
    }
}
