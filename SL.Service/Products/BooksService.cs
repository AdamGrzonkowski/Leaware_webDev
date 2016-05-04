using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SL.Core.Domain.Products;
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

        public List<Core.Domain.Products.Books> GetAllBooks()
        {
            var result = UnitOfWork.BooksRepository.GetAll().ToList();
            return result;
        }

        public Core.Domain.Products.Books GetDetails(long? id)
        {
            var result = UnitOfWork.BooksRepository.GetById(id.Value);
            return result;
        }

        public void Create(Books model)
        {
            UnitOfWork.BooksRepository.Add(model);
            UnitOfWork.Save();
        }
    }
}
