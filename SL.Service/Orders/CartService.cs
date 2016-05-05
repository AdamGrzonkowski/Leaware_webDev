using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SL.Core.Interfaces.Services.Orders;
using SL.Core.Interfaces.UnitOfWork;

namespace SL.Service.Orders
{
    public class CartService : ICartService
    {
        private IUnitOfWork UnitOfWork { get; set; }

        public CartService(IUnitOfWork unitOfWork)
        {
            UnitOfWork = unitOfWork;
        }
    }
}
