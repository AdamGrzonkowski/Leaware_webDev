using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SL.Core.Interfaces.UnitOfWork;
using SL.Service.Users;
// <copyright file="UsersServiceTest.ConstructorTest.g.cs">Copyright ©  2016</copyright>
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
public void ConstructorTest230()
{
    UsersService usersService;
    usersService = this.ConstructorTest((IUnitOfWork)null);
    Assert.IsNotNull((object)usersService);
}
    }
}
