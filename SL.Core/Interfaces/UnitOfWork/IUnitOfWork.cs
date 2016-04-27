using System;

namespace SL.Core.Interfaces.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        int Save();
    }
}