using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    public class BookController : Controller
    {
        //calling way : /Book/GetBook
        public string GetAllBooks()
        {
            return "AllBooks";
        }

        //Check How you can pass Single parameter to this Action Method 
        //calling way :  /Book/GetBook/2
        public string GetBook(int id)
        {
            return $"Book with Id = {id}";
        }

        //Check How you can pass multiple parameter to this Action Method 
        //calling way :  /Book/SearchBook?bookName=MVCBook&authorname=Sachin
        public string SearchBook(string bookName ,string authorName)
        {
            return $"Book with name = {bookName} & Author = {authorName}";
        }
    }
}