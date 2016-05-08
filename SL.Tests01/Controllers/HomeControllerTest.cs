using System;
using System.Web.Mvc;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sklep_Leaware.Controllers;

namespace SL.Tests.Controllers
{
    /// <summary>This class contains parameterized unit tests for HomeController</summary>
    [TestClass]
    [PexClass(typeof(HomeController))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class HomeControllerTest
    {

        /// <summary>Test stub for Index()</summary>
        [PexMethod]
        public ActionResult IndexTest([PexAssumeUnderTest]HomeController target)
        {
            ActionResult result = target.Index();
            return result;
            // TODO: add assertions to method HomeControllerTest.IndexTest(HomeController)
        }

        /// <summary>Test stub for get_ActionNames()</summary>
        [PexMethod]
        public HomeController.ActionNamesClass ActionNamesGetTest([PexAssumeUnderTest]HomeController target)
        {
            HomeController.ActionNamesClass result = target.ActionNames;
            return result;
            // TODO: add assertions to method HomeControllerTest.ActionNamesGetTest(HomeController)
        }

        /// <summary>Test stub for get_Actions()</summary>
        [PexMethod]
        public HomeController ActionsGetTest([PexAssumeUnderTest]HomeController target)
        {
            HomeController result = target.Actions;
            return result;
            // TODO: add assertions to method HomeControllerTest.ActionsGetTest(HomeController)
        }

        /// <summary>Test stub for get_Views()</summary>
        [PexMethod]
        public HomeController.ViewsClass ViewsGetTest([PexAssumeUnderTest]HomeController target)
        {
            HomeController.ViewsClass result = target.Views;
            return result;
            // TODO: add assertions to method HomeControllerTest.ViewsGetTest(HomeController)
        }
    }
}
