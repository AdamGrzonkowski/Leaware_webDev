using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SL.Core.Domain.Orders;

namespace SL.Core.Interfaces.Services.Orders
{
    public interface ICartService
    {
        List<Cart> ShowCart();
        bool AddToCart(long bookId, Cart cart);
        int RemoveFromCart(long bookId, Cart cart);
    }
}
