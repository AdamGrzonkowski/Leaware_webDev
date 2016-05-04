﻿using SL.Core;
using SL.Core.Interfaces.Repositories;
using SL.Core.Interfaces.UnitOfWork;
using SL.Model;

namespace SL.Repository.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        public IUsersRepository UsersRepository { get; private set; }
        public UnitOfWork(ApplicationDbContext context, IUsersRepository usersRepo)
        {
            _context = context;
            UsersRepository = usersRepo;
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