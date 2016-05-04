using System;
using SL.Core.Interfaces.Repositories;

namespace SL.Core.Interfaces.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IUsersRepository UsersRepository { get; }
        IBooksRepository BooksRepository { get; }
        int Save();
    }
}