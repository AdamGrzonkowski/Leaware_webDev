using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using SL.Core.Domain.Orders;
using SL.Core.Interfaces.Services.Orders;

namespace Sklep_Leaware.Controllers
{
    public partial class CartController : Controller
    {
        private ICartService CartService { get; set; }
        public CartController(ICartService cartService)
        {
            CartService = cartService;
        }
        public const string CartSessionKey = "CartId";
        // GET: Cart
        public virtual ActionResult Index()
        {
            var cart = GetCart(this.HttpContext);
            return View(cart);
        }

        public virtual ActionResult AddToCart(long id)
        {
            var cart = GetCart(this.HttpContext);
            if (string.IsNullOrWhiteSpace(cart.Identifier))
            {
                return RedirectToAction(MVC.Users.Login());
            }
            var result = CartService.AddToCart(id, cart);
            return null;
        }

        public Cart GetCart(HttpContextBase context)
        {
            var cart = new Cart {Identifier = GetCartId(context)};
            return cart;
        }

        public Cart GetCart(Controller controller)
        {
            return GetCart(controller.HttpContext);
        }

        public string GetCartId(HttpContextBase context)
        {
            if (context.Session[CartSessionKey] == null)
            {
                if (Request.Cookies[FormsAuthentication.FormsCookieName] != null)
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
            return String.Empty;
        }
    }
}