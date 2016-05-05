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
        List<Cart> GetCartItems(Cart cart);
        bool AddToCart(long bookId, Cart cart);
        int RemoveFromCart(long bookId, Cart cart);
        void EmptyCart(Cart cart);
        decimal GetTotalPrice(Cart cart);
        long CreateOrder(Order order, Cart cart);
        int GetCount(Cart cart);
    }
}
