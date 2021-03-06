using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SL.Core.Interfaces.UnitOfWork;
using System.Collections.Generic;
using SL.Core.Domain.Orders;
using SL.Service.Users;
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace SL.Tests.Services
{
    public partial class UsersServiceTest
    {

[TestMethod]
[PexGeneratedBy(typeof(UsersServiceTest))]
public void GetAllUserOrdersTest63()
{
    UsersService usersService;
    List<Order> list;
    usersService = new UsersService((IUnitOfWork)null);
    list = this.GetAllUserOrdersTest(usersService, (string)null);
    Assert.IsNull((object)list);
    Assert.IsNotNull((object)usersService);
}

[TestMethod]
[PexGeneratedBy(typeof(UsersServiceTest))]
public void GetAllUserOrdersTest368()
{
    UsersService usersService;
    List<Order> list;
    usersService = new UsersService((IUnitOfWork)null);
    list = this.GetAllUserOrdersTest(usersService, "");
    Assert.IsNull((object)list);
    Assert.IsNotNull((object)usersService);
}
    }
}
