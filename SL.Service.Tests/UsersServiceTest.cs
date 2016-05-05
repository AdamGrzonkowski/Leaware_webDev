// <copyright file="UsersServiceTest.cs">Copyright ©  2016</copyright>
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SL.Core.Domain.Users;
using SL.Service.Users;

namespace SL.Service.Users.Tests
{
    /// <summary>This class contains parameterized unit tests for UsersService</summary>
    [PexClass(typeof(UsersService))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class UsersServiceTest
    {
        /// <summary>Test stub for Register(Users)</summary>
        [PexMethod]
        public void RegisterTest([PexAssumeUnderTest]UsersService target, global::SL.Core.Domain.Users.Users user)
        {
            target.Register(user);
            // TODO: add assertions to method UsersServiceTest.RegisterTest(UsersService, Users)
        }
    }
}
