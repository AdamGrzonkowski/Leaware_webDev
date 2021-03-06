// <copyright file="CartControllerTest.cs">Copyright ©  2016</copyright>
using System;
using System.Web;
using System.Web.Mvc;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SL.Core.Domain.Orders;
using SL.Core.Interfaces.Services.Orders;
using Sklep_Leaware.Controllers;

namespace Sklep_Leaware.Controllers.Tests
{
    /// <summary>This class contains parameterized unit tests for CartController</summary>
    [PexClass(typeof(CartController))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class CartControllerTest
    {
        /// <summary>Test stub for get_ActionNames()</summary>
        [PexMethod]
        public CartController.ActionNamesClass ActionNamesGetTest([PexAssumeUnderTest]CartController target)
        {
            CartController.ActionNamesClass result = target.ActionNames;
            return result;
            // TODO: add assertions to method CartControllerTest.ActionNamesGetTest(CartController)
        }

        /// <summary>Test stub for get_Actions()</summary>
        [PexMethod]
        public CartController ActionsGetTest([PexAssumeUnderTest]CartController target)
        {
            CartController result = target.Actions;
            return result;
            // TODO: add assertions to method CartControllerTest.ActionsGetTest(CartController)
        }

        /// <summary>Test stub for get_AddToCartParams()</summary>
        [PexMethod]
        public CartController.ActionParamsClass_AddToCart AddToCartParamsGetTest([PexAssumeUnderTest]CartController target)
        {
            CartController.ActionParamsClass_AddToCart result = target.AddToCartParams;
            return result;
            // TODO: add assertions to method CartControllerTest.AddToCartParamsGetTest(CartController)
        }

        /// <summary>Test stub for AddToCart(Int64)</summary>
        [PexMethod]
        public ActionResult AddToCartTest([PexAssumeUnderTest]CartController target, long id)
        {
            ActionResult result = target.AddToCart(id);
            return result;
            // TODO: add assertions to method CartControllerTest.AddToCartTest(CartController, Int64)
        }

        /// <summary>Test stub for get_AddressAndPaymentParams()</summary>
        [PexMethod]
        public CartController.ActionParamsClass_AddressAndPayment AddressAndPaymentParamsGetTest([PexAssumeUnderTest]CartController target)
        {
            CartController.ActionParamsClass_AddressAndPayment result
               = target.AddressAndPaymentParams;
            return result;
            // TODO: add assertions to method CartControllerTest.AddressAndPaymentParamsGetTest(CartController)
        }

        /// <summary>Test stub for AddressAndPayment()</summary>
        [PexMethod]
        public ActionResult AddressAndPaymentTest([PexAssumeUnderTest]CartController target)
        {
            ActionResult result = target.AddressAndPayment();
            return result;
            // TODO: add assertions to method CartControllerTest.AddressAndPaymentTest(CartController)
        }

        /// <summary>Test stub for AddressAndPayment(FormCollection)</summary>
        [PexMethod]
        public ActionResult AddressAndPaymentTest01(
            [PexAssumeUnderTest]CartController target,
            FormCollection values
        )
        {
            ActionResult result = target.AddressAndPayment(values);
            return result;
            // TODO: add assertions to method CartControllerTest.AddressAndPaymentTest01(CartController, FormCollection)
        }

        /// <summary>Test stub for get_CompleteParams()</summary>
        [PexMethod]
        public CartController.ActionParamsClass_Complete CompleteParamsGetTest([PexAssumeUnderTest]CartController target)
        {
            CartController.ActionParamsClass_Complete result = target.CompleteParams;
            return result;
            // TODO: add assertions to method CartControllerTest.CompleteParamsGetTest(CartController)
        }

        /// <summary>Test stub for Complete(Int64)</summary>
        [PexMethod]
        public ActionResult CompleteTest([PexAssumeUnderTest]CartController target, long id)
        {
            ActionResult result = target.Complete(id);
            return result;
            // TODO: add assertions to method CartControllerTest.CompleteTest(CartController, Int64)
        }

        /// <summary>Test stub for .ctor(ICartService)</summary>
        [PexMethod]
        public CartController ConstructorTest(ICartService cartService)
        {
            CartController target = new CartController(cartService);
            return target;
            // TODO: add assertions to method CartControllerTest.ConstructorTest(ICartService)
        }

        /// <summary>Test stub for GetCartId(HttpContextBase)</summary>
        [PexMethod]
        public string GetCartIdTest(
            [PexAssumeUnderTest]CartController target,
            HttpContextBase context
        )
        {
            string result = target.GetCartId(context);
            return result;
            // TODO: add assertions to method CartControllerTest.GetCartIdTest(CartController, HttpContextBase)
        }

        /// <summary>Test stub for GetCart(HttpContextBase)</summary>
        [PexMethod]
        public Cart GetCartTest(
            [PexAssumeUnderTest]CartController target,
            HttpContextBase context
        )
        {
            Cart result = target.GetCart(context);
            return result;
            // TODO: add assertions to method CartControllerTest.GetCartTest(CartController, HttpContextBase)
        }

        /// <summary>Test stub for GetCart(Controller)</summary>
        [PexMethod]
        public Cart GetCartTest01(
            [PexAssumeUnderTest]CartController target,
            Controller controller
        )
        {
            Cart result = target.GetCart(controller);
            return result;
            // TODO: add assertions to method CartControllerTest.GetCartTest01(CartController, Controller)
        }

        /// <summary>Test stub for Index()</summary>
        [PexMethod]
        public ActionResult IndexTest([PexAssumeUnderTest]CartController target)
        {
            ActionResult result = target.Index();
            return result;
            // TODO: add assertions to method CartControllerTest.IndexTest(CartController)
        }

        /// <summary>Test stub for get_RemoveFromCartParams()</summary>
        [PexMethod]
        public CartController.ActionParamsClass_RemoveFromCart RemoveFromCartParamsGetTest([PexAssumeUnderTest]CartController target)
        {
            CartController.ActionParamsClass_RemoveFromCart result
               = target.RemoveFromCartParams;
            return result;
            // TODO: add assertions to method CartControllerTest.RemoveFromCartParamsGetTest(CartController)
        }

        /// <summary>Test stub for RemoveFromCart(Int64)</summary>
        [PexMethod]
        public ActionResult RemoveFromCartTest([PexAssumeUnderTest]CartController target, long id)
        {
            ActionResult result = target.RemoveFromCart(id);
            return result;
            // TODO: add assertions to method CartControllerTest.RemoveFromCartTest(CartController, Int64)
        }

        /// <summary>Test stub for get_Views()</summary>
        [PexMethod]
        public CartController.ViewsClass ViewsGetTest([PexAssumeUnderTest]CartController target)
        {
            CartController.ViewsClass result = target.Views;
            return result;
            // TODO: add assertions to method CartControllerTest.ViewsGetTest(CartController)
        }
    }
}
