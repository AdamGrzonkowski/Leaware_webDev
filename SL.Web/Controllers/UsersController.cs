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
    public partial class UsersController : Controller
    {
        private IUsersService UsersService { get; set; }
        public UsersController(IUsersService usersService)
        {
            UsersService = usersService;
        }

        public virtual ActionResult Index()
        {
            var result = UsersService.GetAllUsers();
            return View(result);
        }

        // GET: Users/Details/5
        public virtual ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var result = UsersService.GetDetails(id);
            if (result == null)
            {
                return HttpNotFound();
            }
            return View(result);
        }

        // GET: Users/Register
        public virtual ActionResult Register()
        {
            return View();
        }

        // POST: Users/Register
        [HttpPost]
        public virtual ActionResult Register(Register model)
        {
            if (ModelState.IsValid)
            {
                var user = Mapper.Map<Register, Users>(model);
                UsersService.Register(user);

                return RedirectToAction(MVC.Users.Index());
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
                    ModelState.AddModelError("Wrong data", CommonResources.UsersController_Login_WrongData);
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
                var result = UsersService.GetAllUserOrders(userName);
                return View(result);
            }
            return RedirectToAction(MVC.Users.Login());
        }

        // GET: Users/Edit/5
        public virtual ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Users/Edit/5
        [HttpPost]
        public virtual ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Users/Delete/5
        public virtual ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Users/Delete/5
        [HttpPost]
        public virtual ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
