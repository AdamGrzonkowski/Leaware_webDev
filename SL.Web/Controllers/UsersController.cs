using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using AutoMapper;
using Sklep_Leaware.IoC;
using SL.Core;
using SL.Core.Domain.Users;
using SL.Core.Interfaces.Services;
using SL.Core.Interfaces.Services.Users;
using SL.Core.Interfaces.UnitOfWork;
using SL.Model;
using SL.Model.Models.Users;

namespace Sklep_Leaware.Controllers
{
    /// <summary>
    /// Controller responsible for user related actions
    /// </summary>
    public partial class UsersController : Controller
    {
        private IUsersService UsersService { get; set; }
        public UsersController(IUsersService usersService)
        {
            UsersService = usersService;
        }

        public virtual ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public virtual ActionResult Register(Register model)
        {
            if (ModelState.IsValid)
            {
                var user = Mapper.Map<Register, Users>(model);
                UsersService.Register(user);

                return RedirectToAction(MVC.Home.Index());
            }
            return View(model);
        }

        public virtual ActionResult Login()
        {
            TempData["ReturnUrl"] = Server.UrlEncode(Request.UrlReferrer.PathAndQuery);
            return View();
        }

        [HttpPost]
        public virtual ActionResult Login(Login model)
        {
            if (ModelState.IsValid)
            {
                var user = Mapper.Map<Login, Users>(model);
                if (UsersService.Login(user))
                {
                    FormsAuthentication.SetAuthCookie(user.Username, false);
                    if (TempData["ReturnUrl"] != null)
                    {
                        var returnUrl = Server.UrlDecode(TempData["ReturnUrl"].ToString());
                        return Redirect(returnUrl);
                    }
                }
                else
                {
                    ModelState.AddModelError(CommonResources.LoginFailedModelError, CommonResources.UsersController_Login_WrongData);
                    return View();
                }
                return RedirectToAction(MVC.Home.Index());
            }
            return View(model);
        }

        public virtual ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            Session.Abandon();

            return RedirectToAction(MVC.Home.Index());
        }

        public virtual ActionResult UserOrders()
        {
            if (Request.Cookies[FormsAuthentication.FormsCookieName] != null)
            {
                var userName = FormsAuthentication.Decrypt(Request.Cookies[FormsAuthentication.FormsCookieName].Value).Name;
                var orders = UsersService.GetAllUserOrders(userName);
                var ordersDetails = UsersService.GetAllUserOrderDetails(orders.Select(x => x.OrderId).ToList());

                var result = new List<UsersOrders>();

                foreach (var order in orders)
                {
                    var userOrder = new UsersOrders
                    {
                        OrderId = order.OrderId,
                        OrderDate = order.OrderDate,
                        Total = order.Total,
                        OrderDetails = ordersDetails.Where(x => x.OrderId == order.OrderId).ToList(),
                        Status = order.Status
                    };
                    result.Add(userOrder);
                }

                return View(result);
            }
            return RedirectToAction(MVC.Users.Login());
        }
    }
}
