// <copyright file="UsersServiceTest.cs">Copyright ©  2016</copyright>
using System;
using System.Collections.Generic;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SL.Core.Domain.Users;
using SL.Core.Interfaces.UnitOfWork;
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
        /// <summary>Test stub for .ctor(IUnitOfWork)</summary>
        [PexMethod]
        public UsersService ConstructorTest(IUnitOfWork unitOfWork)
        {
            UsersService target = new UsersService(unitOfWork);
            return target;
            // TODO: add assertions to method UsersServiceTest.ConstructorTest(IUnitOfWork)
        }

        /// <summary>Test stub for GenerateSalt()</summary>
        [PexMethod]
        public string GenerateSaltTest()
        {
            string result = UsersService.GenerateSalt();
            return result;
            // TODO: add assertions to method UsersServiceTest.GenerateSaltTest()
        }

        /// <summary>Test stub for GetAllUsers()</summary>
        [PexMethod]
        public List<global::SL.Core.Domain.Users.Users> GetAllUsersTest([PexAssumeUnderTest]UsersService target)
        {
            List<global::SL.Core.Domain.Users.Users> result = target.GetAllUsers();
            return result;
            // TODO: add assertions to method UsersServiceTest.GetAllUsersTest(UsersService)
        }

        /// <summary>Test stub for GetDetails(Nullable`1&lt;Int64&gt;)</summary>
        [PexMethod]
        public global::SL.Core.Domain.Users.Users GetDetailsTest([PexAssumeUnderTest]UsersService target, long? id)
        {
            global::SL.Core.Domain.Users.Users result = target.GetDetails(id);
            return result;
            // TODO: add assertions to method UsersServiceTest.GetDetailsTest(UsersService, Nullable`1<Int64>)
        }

        /// <summary>Test stub for HashPassword(String, String)</summary>
        [PexMethod]
        public string HashPasswordTest(string passwd, string salt)
        {
            string result = UsersService.HashPassword(passwd, salt);
            return result;
            // TODO: add assertions to method UsersServiceTest.HashPasswordTest(String, String)
        }

        /// <summary>Test stub for Login(Users)</summary>
        [PexMethod]
        public bool LoginTest([PexAssumeUnderTest]UsersService target, global::SL.Core.Domain.Users.Users user)
        {
            bool result = target.Login(user);
            return result;
            // TODO: add assertions to method UsersServiceTest.LoginTest(UsersService, Users)
        }

        /// <summary>Test stub for Register(Users)</summary>
        [PexMethod]
        public void RegisterTest([PexAssumeUnderTest]UsersService target, global::SL.Core.Domain.Users.Users user)
        {
            target.Register(user);
            // TODO: add assertions to method UsersServiceTest.RegisterTest(UsersService, Users)
        }
    }
}
