using SL.Core.Domain.Products;
using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SL.Core.Domain.Orders;
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
public void EmptyCartTest117()
{
    CartService cartService;
    cartService = new CartService((IUnitOfWork)null);
    this.EmptyCartTest(cartService, (Cart)null);
    Assert.IsNotNull((object)cartService);
}

[TestMethod]
[PexGeneratedBy(typeof(CartServiceTest))]
[PexRaisedException(typeof(NullReferenceException))]
public void EmptyCartTestThrowsNullReferenceException392()
{
    CartService cartService;
    cartService = new CartService((IUnitOfWork)null);
    Cart s0 = new Cart();
    s0.Id = 0L;
    s0.Identifier = (string)null;
    s0.BookId = 0L;
    s0.Count = 0;
    s0.DateCreated = default(DateTime);
    s0.Books = (Books)null;
    this.EmptyCartTest(cartService, s0);
}
    }
}
