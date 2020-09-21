using System.Collections.Generic;
using GoodBooks.Data.Models;

namespace GoodBooks.Services
{
    public interface IBookService
    {
        public IList<Book> GetAllBooks();
        public BookService GetBook(int bookId);
        public void AddBook(Book book);
        public void DeleteBook(int bookId);
    }
}