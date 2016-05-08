using SL.Core.Domain.Products;
using System.Web.Mvc;
using SL.Core.Interfaces.Services.Products;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sklep_Leaware.Controllers;

namespace Sklep_Leaware.Controllers.Tests
{
    /// <summary>This class contains parameterized unit tests for BooksController</summary>
    [TestClass]
    [PexClass(typeof(BooksController))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class BooksControllerTest
    {

        /// <summary>Test stub for .ctor(IBooksService)</summary>
        [PexMethod]
        public BooksController ConstructorTest(IBooksService booksService)
        {
            BooksController target = new BooksController(booksService);
            return target;
            // TODO: add assertions to method BooksControllerTest.ConstructorTest(IBooksService)
        }

        /// <summary>Test stub for Create()</summary>
        [PexMethod]
        public ActionResult CreateTest([PexAssumeUnderTest]BooksController target)
        {
            ActionResult result = target.Create();
            return result;
            // TODO: add assertions to method BooksControllerTest.CreateTest(BooksController)
        }

        /// <summary>Test stub for Create(Books)</summary>
        [PexMethod]
        public ActionResult CreateTest01([PexAssumeUnderTest]BooksController target, Books books)
        {
            ActionResult result = target.Create(books);
            return result;
            // TODO: add assertions to method BooksControllerTest.CreateTest01(BooksController, Books)
        }

        /// <summary>Test stub for Details(Nullable`1&lt;Int64&gt;)</summary>
        [PexMethod]
        public ActionResult DetailsTest([PexAssumeUnderTest]BooksController target, long? id)
        {
            ActionResult result = target.Details(id);
            return result;
            // TODO: add assertions to method BooksControllerTest.DetailsTest(BooksController, Nullable`1<Int64>)
        }

        /// <summary>Test stub for Index()</summary>
        [PexMethod]
        public ActionResult IndexTest([PexAssumeUnderTest]BooksController target)
        {
            ActionResult result = target.Index();
            return result;
            // TODO: add assertions to method BooksControllerTest.IndexTest(BooksController)
        }

        /// <summary>Test stub for get_ActionNames()</summary>
        [PexMethod]
        public BooksController.ActionNamesClass ActionNamesGetTest([PexAssumeUnderTest]BooksController target)
        {
            BooksController.ActionNamesClass result = target.ActionNames;
            return result;
            // TODO: add assertions to method BooksControllerTest.ActionNamesGetTest(BooksController)
        }

        /// <summary>Test stub for get_Actions()</summary>
        [PexMethod]
        public BooksController ActionsGetTest([PexAssumeUnderTest]BooksController target)
        {
            BooksController result = target.Actions;
            return result;
            // TODO: add assertions to method BooksControllerTest.ActionsGetTest(BooksController)
        }

        /// <summary>Test stub for get_CreateParams()</summary>
        [PexMethod]
        public BooksController.ActionParamsClass_Create CreateParamsGetTest([PexAssumeUnderTest]BooksController target)
        {
            BooksController.ActionParamsClass_Create result = target.CreateParams;
            return result;
            // TODO: add assertions to method BooksControllerTest.CreateParamsGetTest(BooksController)
        }

        /// <summary>Test stub for get_DetailsParams()</summary>
        [PexMethod]
        public BooksController.ActionParamsClass_Details DetailsParamsGetTest([PexAssumeUnderTest]BooksController target)
        {
            BooksController.ActionParamsClass_Details result = target.DetailsParams;
            return result;
            // TODO: add assertions to method BooksControllerTest.DetailsParamsGetTest(BooksController)
        }

        /// <summary>Test stub for get_Views()</summary>
        [PexMethod]
        public BooksController.ViewsClass ViewsGetTest([PexAssumeUnderTest]BooksController target)
        {
            BooksController.ViewsClass result = target.Views;
            return result;
            // TODO: add assertions to method BooksControllerTest.ViewsGetTest(BooksController)
        }
    }
}
