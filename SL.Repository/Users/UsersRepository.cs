using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SL.Core;
using SL.Core.Interfaces.Repositories;
using SL.Model;
using SL.Repository._Base;

namespace SL.Repository.Users
{
    public class UsersRepository : Repository<Core.Domain.Users.Users>, IUsersRepository
    {
        public UsersRepository(ApplicationDbContext context) : base(context)
        {
        }

        public ApplicationDbContext DbContext
        {
            get { return Context as ApplicationDbContext; }
        }
    }
}
