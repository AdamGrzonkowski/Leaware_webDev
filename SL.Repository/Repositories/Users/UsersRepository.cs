using SL.Core.Interfaces.Repositories;
using SL.Core.Interfaces.Repositories.Users;
using SL.Model;
using SL.Repository.Repositories._Base;

namespace SL.Repository.Repositories.Users
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
