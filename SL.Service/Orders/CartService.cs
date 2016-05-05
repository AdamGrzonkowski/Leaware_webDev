using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SL.Core.Domain.Orders;
using SL.Core.Domain.Products;
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

        public bool AddToCart(long bookId, Cart cart)
        {
            var cartItem = UnitOfWork.CartRepository.GetAll().FirstOrDefault(x => x.Identifier == cart.Identifier && x.BookId == bookId);

            // If such item doesn't exit yet, create it
            if (cartItem == null)
            {
                cartItem = new Cart
                {
                    BookId = bookId,
                    Identifier = cart.Identifier,
                    Count = 1,
                    DateCreated = DateTime.Now
                };
                UnitOfWork.CartRepository.Add(cartItem);
            }
            else
            {
                // Else increase its count
                cartItem.Count++;
                UnitOfWork.CartRepository.Update(cartItem);
            }
            
            UnitOfWork.Save();
            return true;
        }
        public int RemoveFromCart(long cartItemId, Cart cart)
        {
            var cartItem =
                UnitOfWork.CartRepository.GetAll()
                    .FirstOrDefault(x => x.Identifier == cart.Identifier && x.Id == cartItemId);

            int itemCount = 0;

            if (cartItem != null)
            {
                if (cartItem.Count > 1)
                {
                    cartItem.Count--;
                    itemCount = cartItem.Count;
                    UnitOfWork.CartRepository.Update(cartItem);
                }
                else
                {
                    UnitOfWork.CartRepository.Remove(cartItem);
                }
                UnitOfWork.Save();
            }
            return itemCount;
        }

        public int GetCount(Cart cart)
        {   
            int? count = (from cartItems in UnitOfWork.CartRepository.GetAll()
                          where cartItems.Identifier == cart.Identifier
                          select (int?)cartItems.Count).Sum();
            return count ?? 0;
        }


        public List<Cart> GetCartItems(Cart cart)
        {
            var result = UnitOfWork.CartRepository.GetAll().Where(x => x.Identifier == cart.Identifier).ToList();
            return result;
        }

        public void EmptyCart(Cart cart)
        {
            var cartItems = UnitOfWork.CartRepository.GetAll().Where(x => x.Identifier == cart.Identifier).ToList();
            UnitOfWork.CartRepository.RemoveRange(cartItems);
            UnitOfWork.Save();
        }

        public decimal GetTotalPrice(Cart cart)
        {
            decimal? total = (from cartItems in UnitOfWork.CartRepository.GetAll()
                              where cartItems.Identifier == cart.Identifier
                              select (int?)cartItems.Count *
                              cartItems.Books.Price).Sum();

            return total ?? decimal.Zero;
        }

        public void AddOrder(Order order)
        {
            UnitOfWork.OrdersRepository.Add(order);
            UnitOfWork.Save();
        }

        public bool ValidateOrder(long orderId, string userName)
        {
            var result = UnitOfWork.OrdersRepository.GetAll().Any(x => x.OrderId == orderId && x.Username == userName);
            return result;
        }

        public long CreateOrder(Order order, Cart cart)
        {
            decimal orderTotal = 0;

            var cartItems = GetCartItems(cart);

            foreach (var item in cartItems)
            {
                var orderDetail = new OrderDetail
                {
                    BookId = item.BookId,
                    OrderId = order.OrderId,
                    UnitPrice = item.Books.Price,
                    Quantity = item.Count
                };
                // Set the order total of the shopping cart
                orderTotal += (item.Count*item.Books.Price);
                UnitOfWork.OrderDetailRepository.Add(orderDetail);

            }
            order.Total = orderTotal;
            UnitOfWork.OrdersRepository.Add(order);

            UnitOfWork.Save();
            EmptyCart(cart);

            // Return the OrderId as the confirmation number
            return order.OrderId;
        }

    }
}
