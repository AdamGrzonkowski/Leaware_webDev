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
public void GetAllUserOrderDetailsTest45()
{
    UsersService usersService;
    List<OrderDetail> list;
    usersService = new UsersService((IUnitOfWork)null);
    list = this.GetAllUserOrderDetailsTest(usersService, (List<long>)null);
    Assert.IsNull((object)list);
    Assert.IsNotNull((object)usersService);
}

[TestMethod]
[PexGeneratedBy(typeof(UsersServiceTest))]
public void GetAllUserOrderDetailsTest705()
{
    UsersService usersService;
    List<long> list;
    List<OrderDetail> list1_;
    usersService = new UsersService((IUnitOfWork)null);
    long[] ls = new long[0];
    list = new List<long>((IEnumerable<long>)ls);
    list1_ = this.GetAllUserOrderDetailsTest(usersService, list);
    Assert.IsNull((object)list1_);
    Assert.IsNotNull((object)usersService);
}

[TestMethod]
[PexGeneratedBy(typeof(UsersServiceTest))]
public void GetAllUserOrderDetailsTest618()
{
    UsersService usersService;
    List<long> list;
    List<OrderDetail> list1_;
    usersService = new UsersService((IUnitOfWork)null);
    long[] ls = new long[1];
    list = new List<long>((IEnumerable<long>)ls);
    list1_ = this.GetAllUserOrderDetailsTest(usersService, list);
    Assert.IsNull((object)list1_);
    Assert.IsNotNull((object)usersService);
}
    }
}
