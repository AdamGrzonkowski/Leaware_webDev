using System;
using System.Collections.Generic;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SL.Core.Domain.Orders;
using SL.Core.Interfaces.UnitOfWork;
using SL.Service.Orders;

namespace SL.Tests.Services
{
    /// <summary>This class contains parameterized unit tests for CartService</summary>
    [TestClass]
    [PexClass(typeof(CartService))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class CartServiceTest
    {

        /// <summary>Test stub for .ctor(IUnitOfWork)</summary>
        [PexMethod]
        public CartService ConstructorTest(IUnitOfWork unitOfWork)
        {
            CartService target = new CartService(unitOfWork);
            return target;
            // TODO: add assertions to method CartServiceTest.ConstructorTest(IUnitOfWork)
        }

        /// <summary>Test stub for AddOrder(Order)</summary>
        [PexMethod]
        public void AddOrderTest([PexAssumeUnderTest]CartService target, Order order)
        {
            target.AddOrder(order);
            // TODO: add assertions to method CartServiceTest.AddOrderTest(CartService, Order)
        }

        /// <summary>Test stub for AddToCart(Int64, Cart)</summary>
        [PexMethod]
        public bool AddToCartTest(
            [PexAssumeUnderTest]CartService target,
            long bookId,
            Cart cart
        )
        {
            bool result = target.AddToCart(bookId, cart);
            return result;
            // TODO: add assertions to method CartServiceTest.AddToCartTest(CartService, Int64, Cart)
        }

        /// <summary>Test stub for CreateOrder(Order, Cart)</summary>
        [PexMethod]
        public long? CreateOrderTest(
            [PexAssumeUnderTest]CartService target,
            Order order,
            Cart cart
        )
        {
            long? result = target.CreateOrder(order, cart);
            return result;
            // TODO: add assertions to method CartServiceTest.CreateOrderTest(CartService, Order, Cart)
        }

        /// <summary>Test stub for EmptyCart(Cart)</summary>
        [PexMethod]
        public void EmptyCartTest([PexAssumeUnderTest]CartService target, Cart cart)
        {
            target.EmptyCart(cart);
            // TODO: add assertions to method CartServiceTest.EmptyCartTest(CartService, Cart)
        }

        /// <summary>Test stub for GetCartItems(Cart)</summary>
        [PexMethod]
        public List<Cart> GetCartItemsTest([PexAssumeUnderTest]CartService target, Cart cart)
        {
            List<Cart> result = target.GetCartItems(cart);
            return result;
            // TODO: add assertions to method CartServiceTest.GetCartItemsTest(CartService, Cart)
        }

        /// <summary>Test stub for GetCount(Cart)</summary>
        [PexMethod]
        public int GetCountTest([PexAssumeUnderTest]CartService target, Cart cart)
        {
            int result = target.GetCount(cart);
            return result;
            // TODO: add assertions to method CartServiceTest.GetCountTest(CartService, Cart)
        }

        /// <summary>Test stub for GetTotalPrice(Cart)</summary>
        [PexMethod]
        public decimal GetTotalPriceTest([PexAssumeUnderTest]CartService target, Cart cart)
        {
            decimal result = target.GetTotalPrice(cart);
            return result;
            // TODO: add assertions to method CartServiceTest.GetTotalPriceTest(CartService, Cart)
        }

        /// <summary>Test stub for RemoveFromCart(Int64, Cart)</summary>
        [PexMethod]
        public int? RemoveFromCartTest(
            [PexAssumeUnderTest]CartService target,
            long cartItemId,
            Cart cart
        )
        {
            int? result = target.RemoveFromCart(cartItemId, cart);
            return result;
            // TODO: add assertions to method CartServiceTest.RemoveFromCartTest(CartService, Int64, Cart)
        }

        /// <summary>Test stub for ValidateOrder(Int64, String)</summary>
        [PexMethod]
        public bool ValidateOrderTest(
            [PexAssumeUnderTest]CartService target,
            long orderId,
            string userName
        )
        {
            bool result = target.ValidateOrder(orderId, userName);
            return result;
            // TODO: add assertions to method CartServiceTest.ValidateOrderTest(CartService, Int64, String)
        }
    }
}
