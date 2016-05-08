using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;
using Sklep_Leaware.Controllers;
using Microsoft.Pex.Framework.Generated;
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace SL.Tests.Controllers
{
    public partial class HomeControllerTest
    {

[TestMethod]
[PexGeneratedBy(typeof(HomeControllerTest))]
public void ActionsGetTest380()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      HomeController homeController;
      HomeController homeController1;
      homeController = new HomeController();
      ((Controller)homeController).Resolver = (IDependencyResolver)null;
      ((Controller)homeController).ActionInvoker = (IActionInvoker)null;
      ((Controller)homeController).TempDataProvider = (ITempDataProvider)null;
      ((Controller)homeController).Url = (UrlHelper)null;
      ((Controller)homeController).ViewEngineCollection = (ViewEngineCollection)null;
      ((ControllerBase)homeController).ControllerContext = (ControllerContext)null;
      ((ControllerBase)homeController).TempData = (TempDataDictionary)null;
      ((ControllerBase)homeController).ValidateRequest = false;
      ((ControllerBase)homeController).ValueProvider = (IValueProvider)null;
      ((ControllerBase)homeController).ViewData = (ViewDataDictionary)null;
      disposables.Add((IDisposable)homeController);
      homeController1 = this.ActionsGetTest(homeController);
      disposables.Add((IDisposable)homeController1);
      disposables.Dispose();
      Assert.IsNotNull((object)homeController1);
      Assert.AreEqual<string>("", homeController1.Area);
      Assert.AreEqual<string>("Home", homeController1.Name);
      Assert.IsNotNull(homeController1.Actions);
      Assert.IsTrue
          (object.ReferenceEquals(homeController1.Actions, (object)homeController1));
      Assert.IsNotNull(homeController1.ActionNames);
      Assert.AreEqual<string>("Index", homeController1.ActionNames.Index);
      Assert.IsNotNull(homeController1.Views);
      Assert.AreEqual<string>
          ("~/Views/Home/Index.cshtml", homeController1.Views.Index);
      Assert.IsNotNull(homeController1.Views.ViewNames);
      Assert.AreEqual<string>("Index", homeController1.Views.ViewNames.Index);
      Assert.IsNotNull(((Controller)homeController1).AsyncManager);
      Assert.IsNotNull
          (((Controller)homeController1).AsyncManager.OutstandingOperations);
      Assert.IsNotNull(((Controller)homeController1).AsyncManager.Parameters);
      Assert.AreEqual<int>
          (45000, ((Controller)homeController1).AsyncManager.Timeout);
      Assert.IsNull(((Controller)homeController1).Url);
      Assert.IsNull(((ControllerBase)homeController1).ControllerContext);
      Assert.AreEqual<bool>(true, ((ControllerBase)homeController1).ValidateRequest);
      Assert.IsNotNull((object)homeController);
      Assert.AreEqual<string>("", homeController.Area);
      Assert.AreEqual<string>("Home", homeController.Name);
      Assert.IsNotNull(homeController.Actions);
      Assert.IsTrue
          (object.ReferenceEquals(homeController.Actions, (object)homeController1));
      Assert.IsNotNull(homeController.ActionNames);
      Assert.IsTrue(object.ReferenceEquals
                        (homeController.ActionNames, homeController1.ActionNames));
      Assert.IsNotNull(homeController.Views);
      Assert.IsTrue
          (object.ReferenceEquals(homeController.Views, homeController1.Views));
      Assert.IsNotNull(((Controller)homeController).AsyncManager);
      Assert.IsNotNull
          (((Controller)homeController).AsyncManager.OutstandingOperations);
      Assert.IsNotNull(((Controller)homeController).AsyncManager.Parameters);
      Assert.AreEqual<int>(45000, ((Controller)homeController).AsyncManager.Timeout);
      Assert.IsNull(((Controller)homeController).Url);
      Assert.IsNull(((ControllerBase)homeController).ControllerContext);
      Assert.AreEqual<bool>(false, ((ControllerBase)homeController).ValidateRequest);
    }
}
    }
}
