using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SL.Core.Interfaces.UnitOfWork;
using SL.Service.Orders;
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
    public partial class CartServiceTest
    {

[TestMethod]
[PexGeneratedBy(typeof(CartServiceTest))]
[PexRaisedException(typeof(NullReferenceException))]
public void ValidateOrderTestThrowsNullReferenceException520()
{
    CartService cartService;
    bool b;
    cartService = new CartService((IUnitOfWork)null);
    b = this.ValidateOrderTest(cartService, 0L, (string)null);
}
    }
}
