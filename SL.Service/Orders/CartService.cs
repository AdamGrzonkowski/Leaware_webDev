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

        public bool AddToCart(long bookId = -1, Cart cart = null)
        {
            if (bookId == -1 || cart == null)
            {
                return false;
            }
            var cartItem = UnitOfWork?.CartRepository.GetAll().FirstOrDefault(x => x.Identifier == cart.Identifier && x.BookId == bookId);

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
                UnitOfWork?.CartRepository.Add(cartItem);
            }
            else
            {
                // Else increase its count
                cartItem.Count++;
                UnitOfWork?.CartRepository.Update(cartItem);
            }
            
            UnitOfWork?.Save();
            return true;
        }
        public int? RemoveFromCart(long cartItemId = -1, Cart cart = null)
        {
            if (cartItemId == -1 || cart == null)
            {
                return null;
            }

            var cartItem =
                UnitOfWork?.CartRepository.GetAll()
                    .FirstOrDefault(x => x.Identifier == cart.Identifier && x.Id == cartItemId);

            int itemCount = 0;

            if (cartItem != null)
            {
                if (cartItem.Count > 1)
                {
                    cartItem.Count--;
                    itemCount = cartItem.Count;
                    UnitOfWork?.CartRepository.Update(cartItem);
                }
                else
                {
                    UnitOfWork?.CartRepository.Remove(cartItem);
                }
                UnitOfWork?.Save();
            }
            return itemCount;
        }

        public int GetCount(Cart cart)
        {
            if (cart == null || UnitOfWork == null)
            {
                return 0;
            }

            int? count = (from cartItems in UnitOfWork.CartRepository.GetAll()
                          where cartItems.Identifier == cart.Identifier
                          select (int?)cartItems.Count).Sum();
            return count ?? 0;
        }


        public List<Cart> GetCartItems(Cart cart)
        {
            List<Cart> result = null;
            if (cart != null)
            {
                result = UnitOfWork?.CartRepository.GetAll().Where(x => x.Identifier == cart.Identifier).ToList();
                
            }
            return result;
        }

        public void EmptyCart(Cart cart)
        {
            if (cart != null)
            {
                var cartItems = UnitOfWork?.CartRepository.GetAll().Where(x => x.Identifier == cart.Identifier).ToList();
                UnitOfWork?.CartRepository.RemoveRange(cartItems);
                UnitOfWork?.Save();
            }
        }

        public decimal GetTotalPrice(Cart cart)
        {
            if (cart == null || UnitOfWork == null)
            {
                return decimal.Zero;
            }

            decimal? total = (from cartItems in UnitOfWork.CartRepository.GetAll()
                              where cartItems.Identifier == cart.Identifier
                              select (int?)cartItems.Count *
                              cartItems.Books.Price).Sum();

            return total ?? decimal.Zero;
        }

        public void AddOrder(Order order)
        {
            if (order != null)
            {
                UnitOfWork?.OrdersRepository.Add(order);
                UnitOfWork?.Save();
            }
        }

        public bool ValidateOrder(long orderId, string userName)
        {
            var result = UnitOfWork?.OrdersRepository.GetAll().Any(x => x.OrderId == orderId && x.Username == userName);
            return result.GetValueOrDefault(false);
        }

        public long? CreateOrder(Order order, Cart cart)
        {
            if (order == null || cart == null)
            {
                return null;
            }
            
            var cartItems = GetCartItems(cart);
            if (cartItems == null)
            {
                return null;
            }

            decimal orderTotal = 0;

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
                UnitOfWork?.OrderDetailRepository.Add(orderDetail);

            }
            order.Total = orderTotal;
            UnitOfWork?.OrdersRepository.Add(order);

            UnitOfWork?.Save();
            EmptyCart(cart);

            // Return the OrderId as the confirmation number
            return order.OrderId;
        }

    }
}
