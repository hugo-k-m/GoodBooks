using System;
using System.Collections.Generic;
using System.Linq;
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
            _db.Add(book);
            _db.SaveChanges();
        }

        public void DeleteBook(int bookId)
        {
            var bookToDelete = _db.Books.Find(bookId);

            if (bookToDelete != null)
            {
                _db.Remove(bookToDelete);
                _db.SaveChanges();
            }
            else
            {
                throw new InvalidOperationException("Cannot delete book that doesn't exist.");
            }
        }

        public IList<Book> GetAllBooks()
        {
            return _db.Books.ToList();
        }

        public Book GetBook(int bookId)
        {
            var book = _db.Books.Find(bookId);

            return _db.Books.Find(bookId);
        }
    }
}
