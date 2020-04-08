using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Repository
{
    /// <summary>
    /// Consider now you are working with Database so we make this data in memory only 
    /// </summary>
    public class BookRepository
    {
        public List<BookModel> GetAllBooks()
        {
            return DataSource();
        }
        public BookModel GetBookById(int id)
        {
            return DataSource().Where(i=>i.Id==id).FirstOrDefault();
        }
        public List<BookModel> SearchBook(string title,string authorName)
        {
            return DataSource().Where(x => x.Title.Contains(title) || x.Author.Contains(authorName)).ToList();
        }
        private List<BookModel> DataSource()
        {
            return new List<BookModel>() 
            {
                new BookModel(){Id =1, Title="MVC", Author = "Sachin", Description="This is the description for MVC book", Category="Programming", Language="English", TotalPages=134 },
                new BookModel(){Id =2, Title="Dot Net Core", Author = "Dwivedi", Description="This is the description for Dot Net Core book", Category="Framework", Language="Chinese", TotalPages=567 },
                new BookModel(){Id =3, Title="C#", Author = "Abhishek", Description="This is the description for C# book", Category="Developer", Language="Hindi", TotalPages=897 },
                new BookModel(){Id =4, Title="Java", Author = "Raheja", Description="This is the description for Java book", Category="Concept", Language="English", TotalPages=564 },
                new BookModel(){Id =5, Title="Php", Author = "janhvi", Description="This is the description for Php book", Category="Programming", Language="English", TotalPages=100 },
                new BookModel(){Id =6, Title="Azure DevOps", Author = "Jeffery", Description="This is the description for Azure Devops book", Category="DevOps", Language="English", TotalPages=800 },
            };
        }
    }
}
