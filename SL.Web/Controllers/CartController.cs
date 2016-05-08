using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using AutoMapper;
using SL.Core.Domain.Orders;
using SL.Core.Domain.Users;
using SL.Core.Interfaces.Services.Orders;
using SL.Model.Models.Orders;
using SL.Model.Models.Users;

namespace Sklep_Leaware.Controllers
{
    /// <summary>
    /// Controller responsible for cart related actions
    /// </summary>
    public partial class CartController : Controller
    {
        private ICartService CartService { get; set; }
        public CartController(ICartService cartService)
        {
            CartService = cartService;
        }

        // Stores session key of shopping cart
        public static readonly string CartSessionKey = CommonResources.CartSessionKey;

        public virtual ActionResult Index()
        {
            var cart = GetCart(this.HttpContext);
            var viewModel = new ShoppingCart
            {
                CartItems = CartService.GetCartItems(cart),
                CartTotal = CartService.GetTotalPrice(cart)
            };
            return View(viewModel);
        }

        public virtual ActionResult AddToCart(long id)
        {
            var cart = GetCart(this.HttpContext);
            if (string.IsNullOrWhiteSpace(cart.Identifier))
            {
                return RedirectToAction(MVC.Users.Login());
            }
            CartService.AddToCart(id, cart);

            return RedirectToAction(MVC.Books.Index());
        }

        [HttpPost]
        public virtual ActionResult RemoveFromCart(long id)
        {
            var cart = GetCart(this.HttpContext);
            if (string.IsNullOrWhiteSpace(cart.Identifier))
            {
                return RedirectToAction(MVC.Users.Login());
            }

            int? itemCount =  CartService.RemoveFromCart(id, cart);
            if (itemCount.HasValue)
            {
                var results = new ShoppingCartRemove
                {
                    Message = CommonResources.RemoveItemMessage,
                    CartTotal = CartService.GetTotalPrice(cart),
                    CartCount = CartService.GetCount(cart),
                    ItemCount = itemCount.Value,
                    DeleteId = id
                };
                return Json(results);
            }
            return null;

        }

        public virtual ActionResult AddressAndPayment()
        {
            return View();
        }

        [HttpPost]
        public virtual ActionResult AddressAndPayment(FormCollection values)
        {
            var order = new Order();
            TryUpdateModel(order);

            try
            {
                var cart = GetCart(this.HttpContext);
                order.Username = cart.Identifier;
                order.OrderDate = DateTime.Now;

                CartService.CreateOrder(order, cart);

                return RedirectToAction(MVC.Cart.Complete(order.OrderId));
            }
            catch
            {
                return View(order);
            }
        }

        public virtual ActionResult Complete(long id)
        {
            var userName = GetCart(this.HttpContext).Identifier;
            // Check if it's this user order
            bool isValid = CartService.ValidateOrder(id, userName);
            if (isValid)
            {
                return View(id);
            }
            else
            {
                return View(MVC.Shared.Views.Error);
            }
        }


        #region GetCartActions
        public virtual Cart GetCart(HttpContextBase context)
        {
            var cart = new Cart {Identifier = GetCartId(context)};
            return cart;
        }

        public virtual Cart GetCart(Controller controller)
        {
            return GetCart(controller.HttpContext);
        }

        public virtual string GetCartId(HttpContextBase context)
        {
            if (context?.Session[CartSessionKey] == null)
            {
                if (Request?.Cookies[FormsAuthentication.FormsCookieName] != null)
                {
                    context.Session[CartSessionKey] =
                        FormsAuthentication.Decrypt(Request.Cookies[FormsAuthentication.FormsCookieName].Value).Name;
                    return context.Session[CartSessionKey].ToString();
                }
                else
                {
                    // Uncomment to allow adding items to cart without logging in
                    //Guid tempCartId = Guid.NewGuid();
                   // context.Session[CartSessionKey] = tempCartId.ToString();
                }
            }
            return context?.Session[CartSessionKey]?.ToString();
        }
        #endregion
    }
}