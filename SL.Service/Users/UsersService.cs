using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using SL.Core.Domain.Orders;
using SL.Core.Interfaces.Services;
using SL.Core.Interfaces.Services.Users;
using SL.Core.Interfaces.UnitOfWork;

namespace SL.Service.Users
{
    public class UsersService : IUsersService
    {
        private IUnitOfWork UnitOfWork { get; set; }

        public UsersService(IUnitOfWork unitOfWork)
        {
            UnitOfWork = unitOfWork;
        }

        public List<Core.Domain.Users.Users> GetAllUsers()
        {
            var result = UnitOfWork?.UsersRepository.GetAll().ToList();
            return result;
        }

        public Core.Domain.Users.Users GetDetails(long? id)
        {
            var result = UnitOfWork?.UsersRepository.GetById(id.Value);
            return result;
        }

        public void Register(Core.Domain.Users.Users user)
        {
            if (user != null)
            {
                user.Salt = GenerateSalt();
                user.Password = HashPassword(user.Password, user.Salt);
                user.IsActive = true;

                UnitOfWork.UsersRepository.Add(user);
                UnitOfWork.Save();
            }
        }

        public bool Login(Core.Domain.Users.Users user)
        {
            var userByUsername = UnitOfWork?.UsersRepository.GetAll().FirstOrDefault(x => x.Username == user.Username);
            if (userByUsername == null)
            {
                return false;
            }

            var salt = userByUsername.Salt;
            var hashPass = HashPassword(user.Password, salt);

            return userByUsername.Password == hashPass;
        }

        public List<Order> GetAllUserOrders(string username)
        {
            if (username != null)
            {
                var result = UnitOfWork?.OrdersRepository.GetAll().Where(x => x.Username == username).ToList();
                return result;
            }
            return null;
        }

        public List<OrderDetail> GetAllUserOrderDetails(List<long> orderIds)
        {
            if (orderIds != null)
            {
                var ordersDetails = UnitOfWork?.OrderDetailRepository.GetAll().Where(x => orderIds.Contains(x.OrderId)).ToList();
                return ordersDetails;
            }
            return null;

        }

        #region Helpers
        public static string HashPassword(string passwd, string salt = null)
        {

            SHA512Managed sha = new SHA512Managed();

            var salted = string.Format("{0}{{{1}}}", passwd, salt);
            var saltedBytes = Encoding.ASCII.GetBytes(salted);
            var digest = sha.ComputeHash(Encoding.ASCII.GetBytes(salted));

            for (var i = 1; i < 5000; i++)
            {

                var merged = new byte[digest.Length + saltedBytes.Length];
                digest.CopyTo(merged, 0);
                saltedBytes.CopyTo(merged, digest.Length);
                digest = sha.ComputeHash(merged);
            }

            return Convert.ToBase64String(digest);
        }

        public static string GenerateSalt()
        {

            var result = new byte[30];

            RNGCryptoServiceProvider crypto = new RNGCryptoServiceProvider();
            crypto.GetBytes(result);
            return Convert.ToBase64String(result);
        }
        #endregion
    }
}
