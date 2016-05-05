using System.Collections.Generic;
using SL.Core.Domain.Orders;

namespace SL.Core.Interfaces.Services.Users
{
    public interface IUsersService
    {
        List<Domain.Users.Users> GetAllUsers();
        Domain.Users.Users GetDetails(long? id);
        void Register(Domain.Users.Users user);
        bool Login(Domain.Users.Users user);
        List<Order> GetAllUserOrders(string username);
    }
}
