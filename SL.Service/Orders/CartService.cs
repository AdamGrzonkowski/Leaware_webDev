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
        public int RemoveFromCart(long bookId, Cart cart)
        {
            var cartItem =
                UnitOfWork.CartRepository.GetAll()
                    .FirstOrDefault(x => x.Identifier == cart.Identifier && x.BookId == bookId);

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


        public List<Cart> ShowCart()
        {
            var result = UnitOfWork.CartRepository.GetAll().ToList();
            return result;
        }

    }
}
