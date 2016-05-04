using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SL.Core.Domain;

namespace SL.Core.Interfaces.Services
{
    public interface IUsersService
    {
        List<Users> GetAllUsers();
        Users GetDetails(long? id);
        void Register(Users user);
        bool Login(Users user);
    }
}
