using System.Collections.Generic;
using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SL.Core.Domain.Users;
using SL.Core.Interfaces.UnitOfWork;
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
public void RegisterTest403()
{
    UsersService usersService;
    usersService = new UsersService((IUnitOfWork)null);
    this.RegisterTest(usersService, (global::SL.Core.Domain.Users.Users)null);
    Assert.IsNotNull((object)usersService);
}

[TestMethod]
[PexGeneratedBy(typeof(UsersServiceTest))]
[PexDescription("the test state was: path bounds exceeded")]
public void RegisterTest19()
{
    UsersService usersService;
    usersService = new UsersService((IUnitOfWork)null);
    global::SL.Core.Domain.Users.Users s0 = new global::SL.Core.Domain.Users.Users()
      ;
    s0.Id = 0L;
    s0.Email = (string)null;
    s0.Username = (string)null;
    s0.Salt = (string)null;
    s0.Password = (string)null;
    s0.IsActive = false;
    s0.Roles = (ICollection<Roles>)null;
    this.RegisterTest(usersService, s0);
}
    }
}
