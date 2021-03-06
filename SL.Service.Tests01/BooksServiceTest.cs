// <copyright file="BooksServiceTest.cs">Copyright ©  2016</copyright>
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SL.Core.Domain.Products;
using SL.Service.Products;

namespace SL.Service.Products.Tests
{
    /// <summary>This class contains parameterized unit tests for BooksService</summary>
    [PexClass(typeof(BooksService))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class BooksServiceTest
    {
        /// <summary>Test stub for GetDetails(Nullable`1&lt;Int64&gt;)</summary>
        [PexMethod]
        public Books GetDetailsTest([PexAssumeUnderTest]BooksService target, long? id)
        {
            Books result = target.GetDetails(id);
            return result;
            // TODO: add assertions to method BooksServiceTest.GetDetailsTest(BooksService, Nullable`1<Int64>)
        }
    }
}
