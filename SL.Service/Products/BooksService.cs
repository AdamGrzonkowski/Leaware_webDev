using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SL.Core.Interfaces.Services;
using SL.Core.Interfaces.UnitOfWork;

namespace SL.Service.Products
{
    public class BooksService : IBooksService
    {
        private IUnitOfWork UnitOfWork { get; set; }

        public BooksService(IUnitOfWork unitOfWork)
        {
            UnitOfWork = unitOfWork;
        }
    }
}
