using System;
using System.Collections.Generic;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SL.Core.Domain.Products;
using SL.Core.Interfaces.UnitOfWork;
using SL.Service.Products;

namespace SL.Tests.Services
{
    /// <summary>This class contains parameterized unit tests for BooksService</summary>
    [TestClass]
    [PexClass(typeof(BooksService))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class BooksServiceTest
    {

        /// <summary>Test stub for .ctor(IUnitOfWork)</summary>
        [PexMethod]
        public BooksService ConstructorTest(IUnitOfWork unitOfWork)
        {
            BooksService target = new BooksService(unitOfWork);
            return target;
            // TODO: add assertions to method BooksServiceTest.ConstructorTest(IUnitOfWork)
        }

        /// <summary>Test stub for Create(Books)</summary>
        [PexMethod]
        public void CreateTest([PexAssumeUnderTest]BooksService target, Books model)
        {
            target.Create(model);
            // TODO: add assertions to method BooksServiceTest.CreateTest(BooksService, Books)
        }

        /// <summary>Test stub for GetAllBooks()</summary>
        [PexMethod]
        public List<Books> GetAllBooksTest([PexAssumeUnderTest]BooksService target)
        {
            List<Books> result = target.GetAllBooks();
            return result;
            // TODO: add assertions to method BooksServiceTest.GetAllBooksTest(BooksService)
        }

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
