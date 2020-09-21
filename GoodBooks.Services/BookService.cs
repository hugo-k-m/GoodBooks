using System;
using System.Collections.Generic;
using GoodBooks.Data;
using GoodBooks.Data.Models;

namespace GoodBooks.Services
{
    public class BookService : IBookService
    {
        private readonly GoodBooksDbContext _db;

        public BookService(GoodBooksDbContext db)
        {
            _db = db;
        }

        public void AddBook(Book book)
        {
            throw new NotImplementedException();
        }

        public void DeleteBook(int bookId)
        {
            throw new NotImplementedException();
        }

        public IList<Book> GetAllBooks()
        {
            throw new NotImplementedException();
        }

        public BookService GetBook(int bookId)
        {
            throw new NotImplementedException();
        }
    }
}
