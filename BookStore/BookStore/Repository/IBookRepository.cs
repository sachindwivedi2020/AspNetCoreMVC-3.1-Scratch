using BookStore.Models;
using System.Collections.Generic;

namespace BookStore.Repository
{
    public interface IBookRepository
    {
        int AddNewBook(BookModel bookModel);
        List<BookModel> GetAllBooks();
        BookModel GetBookById(int id);
        List<BookModel> SearchBook(string title, string authorName);
    }
}