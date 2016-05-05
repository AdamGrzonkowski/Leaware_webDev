using System.Collections.Generic;

namespace SL.Core.Interfaces.Services.Users
{
    public interface IUsersService
    {
        List<Domain.Users.Users> GetAllUsers();
        Domain.Users.Users GetDetails(long? id);
        void Register(Domain.Users.Users user);
        bool Login(Domain.Users.Users user);
    }
}
