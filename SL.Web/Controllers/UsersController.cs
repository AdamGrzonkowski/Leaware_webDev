using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SL.Core;
using SL.Core.Domain;
using SL.Core.Interfaces.Services;
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

        // GET: Users/Create
        public virtual ActionResult Create()
        {
            return View();
        }

        // POST: Users/Create
        [HttpPost]
        public virtual ActionResult Create(Register model)
        {
            if (ModelState.IsValid)
            {
                var newUser = new Users
                {
                    Email = model.Email,
                    Username = model.Username,
                    Password = model.Password
                };
                UsersService.Register(newUser);

                return RedirectToAction("Index");
            }
            return View(model);
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
