﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Models;
using BookStore.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRepository _bookRepository = null;
        public BookController()
        {
            _bookRepository = new BookRepository();
        }
        public ViewResult GetAllBooks()
        {
            var data= _bookRepository.GetAllBooks();
            return View(data);
        }
        public ViewResult GetBook(int id)
        {
            var data= _bookRepository.GetBookById(id);
            return View(data);
        }

        public List<BookModel> SearchBook(string bookName ,string authorName)
        {
            return _bookRepository.SearchBook(bookName, authorName);
        }

        public ViewResult AddNewBook()
        {
            return View();
        }

        public ViewResult SaveBook()
        {
            return View();
        }
    }
}