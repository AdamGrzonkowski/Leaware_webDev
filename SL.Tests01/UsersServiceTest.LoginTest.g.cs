using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SL.Core.Domain.Users;
using SL.Core.Interfaces.UnitOfWork;
using SL.Service.Users;
// <copyright file="UsersServiceTest.LoginTest.g.cs">Copyright ©  2016</copyright>
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace SL.Service.Users.Tests
{
    public partial class UsersServiceTest
    {

[TestMethod]
[PexGeneratedBy(typeof(UsersServiceTest))]
public void LoginTest373()
{
    UsersService usersService;
    bool b;
    usersService = new UsersService((IUnitOfWork)null);
    b = this.LoginTest(usersService, (global::SL.Core.Domain.Users.Users)null);
    Assert.AreEqual<bool>(false, b);
    Assert.IsNotNull((object)usersService);
}
    }
}
