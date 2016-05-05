using System;
using SL.Core.Interfaces.Repositories;
using SL.Core.Interfaces.Repositories.Orders;
using SL.Core.Interfaces.Repositories.Products;
using SL.Core.Interfaces.Repositories.Users;

namespace SL.Core.Interfaces.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IUsersRepository UsersRepository { get; }
        IBooksRepository BooksRepository { get; }
        ICartRepository CartRepository { get; }
        IOrdersRepository OrdersRepository { get; }
        IOrderDetailRepository OrderDetailRepository { get; }
        int Save();
    }
}