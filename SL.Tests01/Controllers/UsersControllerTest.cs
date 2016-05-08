using System;
using System.Web.Mvc;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sklep_Leaware.Controllers;
using SL.Core.Interfaces.Services.Users;
using SL.Model.Models.Users;

namespace SL.Tests.Controllers
{
    /// <summary>This class contains parameterized unit tests for UsersController</summary>
    [TestClass]
    [PexClass(typeof(UsersController))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class UsersControllerTest
    {

        /// <summary>Test stub for .ctor(IUsersService)</summary>
        [PexMethod]
        public UsersController ConstructorTest(IUsersService usersService)
        {
            UsersController target = new UsersController(usersService);
            return target;
            // TODO: add assertions to method UsersControllerTest.ConstructorTest(IUsersService)
        }

        /// <summary>Test stub for LogOut()</summary>
        [PexMethod]
        public ActionResult LogOutTest([PexAssumeUnderTest]UsersController target)
        {
            ActionResult result = target.LogOut();
            return result;
            // TODO: add assertions to method UsersControllerTest.LogOutTest(UsersController)
        }

        /// <summary>Test stub for Login()</summary>
        [PexMethod]
        public ActionResult LoginTest([PexAssumeUnderTest]UsersController target)
        {
            ActionResult result = target.Login();
            return result;
            // TODO: add assertions to method UsersControllerTest.LoginTest(UsersController)
        }

        /// <summary>Test stub for Login(Login)</summary>
        [PexMethod]
        public ActionResult LoginTest01([PexAssumeUnderTest]UsersController target, Login model)
        {
            ActionResult result = target.Login(model);
            return result;
            // TODO: add assertions to method UsersControllerTest.LoginTest01(UsersController, Login)
        }

        /// <summary>Test stub for Register()</summary>
        [PexMethod]
        public ActionResult RegisterTest([PexAssumeUnderTest]UsersController target)
        {
            ActionResult result = target.Register();
            return result;
            // TODO: add assertions to method UsersControllerTest.RegisterTest(UsersController)
        }

        /// <summary>Test stub for Register(Register)</summary>
        [PexMethod]
        public ActionResult RegisterTest01([PexAssumeUnderTest]UsersController target, Register model)
        {
            ActionResult result = target.Register(model);
            return result;
            // TODO: add assertions to method UsersControllerTest.RegisterTest01(UsersController, Register)
        }

        /// <summary>Test stub for UserOrders()</summary>
        [PexMethod]
        public ActionResult UserOrdersTest([PexAssumeUnderTest]UsersController target)
        {
            ActionResult result = target.UserOrders();
            return result;
            // TODO: add assertions to method UsersControllerTest.UserOrdersTest(UsersController)
        }

        /// <summary>Test stub for get_ActionNames()</summary>
        [PexMethod]
        public UsersController.ActionNamesClass ActionNamesGetTest([PexAssumeUnderTest]UsersController target)
        {
            UsersController.ActionNamesClass result = target.ActionNames;
            return result;
            // TODO: add assertions to method UsersControllerTest.ActionNamesGetTest(UsersController)
        }

        /// <summary>Test stub for get_Actions()</summary>
        [PexMethod]
        public UsersController ActionsGetTest([PexAssumeUnderTest]UsersController target)
        {
            UsersController result = target.Actions;
            return result;
            // TODO: add assertions to method UsersControllerTest.ActionsGetTest(UsersController)
        }

        /// <summary>Test stub for get_LoginParams()</summary>
        [PexMethod]
        public UsersController.ActionParamsClass_Login LoginParamsGetTest([PexAssumeUnderTest]UsersController target)
        {
            UsersController.ActionParamsClass_Login result = target.LoginParams;
            return result;
            // TODO: add assertions to method UsersControllerTest.LoginParamsGetTest(UsersController)
        }

        /// <summary>Test stub for get_RegisterParams()</summary>
        [PexMethod]
        public UsersController.ActionParamsClass_Register RegisterParamsGetTest([PexAssumeUnderTest]UsersController target)
        {
            UsersController.ActionParamsClass_Register result = target.RegisterParams;
            return result;
            // TODO: add assertions to method UsersControllerTest.RegisterParamsGetTest(UsersController)
        }

        /// <summary>Test stub for get_Views()</summary>
        [PexMethod]
        public UsersController.ViewsClass ViewsGetTest([PexAssumeUnderTest]UsersController target)
        {
            UsersController.ViewsClass result = target.Views;
            return result;
            // TODO: add assertions to method UsersControllerTest.ViewsGetTest(UsersController)
        }
    }
}
