using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SL.Core;
using SL.Core.Domain;
using SL.Core.Interfaces.UnitOfWork;
using SL.Model;

namespace Sklep_Leaware.Controllers
{
    public partial class UsersController : Controller
    {
        private IUnitOfWork UnitOfWork { get; set; }

        public UsersController(IUnitOfWork unitOfWork)
        {
            UnitOfWork = unitOfWork;
        }

        public virtual ActionResult Index()
        {
            var result = UnitOfWork.UsersRepository.GetAll();
            return View(result);
        }

        // GET: Users/Details/5
        public virtual ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var result = UnitOfWork.UsersRepository.GetById(id.Value);
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
        public virtual ActionResult Create(Users model)
        {
            if (ModelState.IsValid)
            {
                UnitOfWork.UsersRepository.Add(model);
                UnitOfWork.Save();
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
