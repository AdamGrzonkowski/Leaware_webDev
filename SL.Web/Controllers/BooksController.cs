﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SL.Core.Domain.Products;
using SL.Core.Interfaces.Services;
using SL.Core.Interfaces.Services.Products;
using SL.Model;

namespace Sklep_Leaware.Controllers
{
    /// <summary>
    /// Controller responsible for book related actions
    /// </summary>
    public partial class BooksController : Controller
    {
        private IBooksService BooksService { get; set; }
        public BooksController(IBooksService booksService)
        {
            BooksService = booksService;
        }

        public virtual ActionResult Index()
        {
            var result = BooksService.GetAllBooks();
            return View(result);
        }

        public virtual ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var result = BooksService.GetDetails(id);
            if (result == null)
            {
                return HttpNotFound();
            }
            return View(result);
        }

        public virtual ActionResult Create()
        {
            return View();
        }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public virtual ActionResult Create(Books books)
        {
            if (ModelState.IsValid)
            {
                BooksService.Create(books);

                return RedirectToAction(MVC.Books.Index());
            }
            return View(books);
        }
    }
}
