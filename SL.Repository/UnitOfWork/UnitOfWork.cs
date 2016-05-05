using SL.Core;
using SL.Core.Interfaces.Repositories;
using SL.Core.Interfaces.Repositories.Orders;
using SL.Core.Interfaces.Repositories.Products;
using SL.Core.Interfaces.Repositories.Users;
using SL.Core.Interfaces.UnitOfWork;
using SL.Model;

namespace SL.Repository.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        public IUsersRepository UsersRepository { get; private set; }
        public IBooksRepository BooksRepository { get; private set; }
        public ICartRepository CartRepository { get; private set; }
        public IOrdersRepository OrdersRepository { get; private set; }
        public IOrderDetailRepository OrderDetailRepository { get; private set; }

        public UnitOfWork(ApplicationDbContext context, IUsersRepository usersRepo, 
            IBooksRepository booksRepo, ICartRepository cartRepo, IOrdersRepository orderRepo, 
            IOrderDetailRepository orderDetailsRepo)
        {
            _context = context;
            UsersRepository = usersRepo;
            BooksRepository = booksRepo;
            CartRepository = cartRepo;
            OrdersRepository = orderRepo;
            OrderDetailRepository = orderDetailsRepo;
        }

        public int Save()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}