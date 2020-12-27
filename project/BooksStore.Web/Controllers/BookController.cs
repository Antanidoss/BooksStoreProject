﻿using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BooksStore.Web.Interfaces.Managers;
using BooksStore.Web.Models.Pagination;
using BooksStore.Web.Models.ViewModel.CreateModel;
using BooksStore.Web.Models.ViewModel.ReadModel;
using BooksStore.Web.Models.ViewModel.UpdateModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BooksStore.Web.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookViewModelService _bookService;

        private readonly IMapper _mapper;

        public BookController(IBookViewModelService bookService, IMapper mapper)
        {
            _bookService = bookService;
            _mapper = mapper;
        }

        public async Task<IActionResult> IndexBooks(int pageNum = 1, BookListViewModel bookList = null)
        {           
            if (bookList?.BookIndexModel?.Objects == null)
            {
                bookList = new BookListViewModel(pageNum, PageSizes.Books, await _bookService.GetCountAsync(), 
                    await _bookService.GetBooksAsync(pageNum));
            }               

            return View(bookList);                       
        }

        [HttpGet]
        public async Task<IActionResult> IndexBook(int? bookId)
        {            
            var book = await _bookService.GetBookByIdAsync(bookId.Value);                                           

            return View(book);                        
        }

        [Authorize(Roles = "admin")]
        public async Task<IActionResult> IndexBooksAdmin(int pageNum = 1)
        {
            return await IndexBooks(pageNum);
        }

        [Authorize(Roles = "admin")]
        [HttpGet]
        public IActionResult AddBook() => View();

        [Authorize(Roles = "admin")]
        [HttpPost]
        public async Task<IActionResult> AddBook(BookCreateModel model)
        {
            if (ModelState.IsValid)
            {
                return View(model);
            }

            await _bookService.AddBookAsync(model);

            return RedirectToAction(nameof(IndexBooksAdmin));                       
        }

        [Authorize(Roles = "admin")]
        [HttpGet]
        public async Task<IActionResult> RemoveBook(int? bookId)
        {
            if (!bookId.HasValue)
            {
                return View(StatusCode(404));
            }

            await _bookService.RemoveBookAsync(bookId.Value);          

            return RedirectToAction(nameof(IndexBooksAdmin));                       
        }

        [Authorize(Roles = "admin")]
        [HttpGet]
        public async Task<IActionResult> UpdateBook(int? bookId)
        {
            if (!bookId.HasValue)
            {
                return View(StatusCode(404));
            }

            var book = await _bookService.GetBookByIdAsync(bookId.Value);

            return View(_mapper.Map<BookUpdateModel>(book));            
        }

        [Authorize(Roles = "admin")]
        [HttpPost]
        public async Task<IActionResult> UpdateBook(BookUpdateModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            await _bookService.UpdateBookAsync(model);

            return RedirectToAction(nameof(IndexBooksAdmin));           
        }

        [HttpGet]
        public async Task<IActionResult> IndexByCategory(int? categoryId, string categoryName, int pageNum = 1)
        {
            if (!categoryId.HasValue)
            {
                return View(StatusCode(404));
            }

            var booksCategory = await _bookService.GetBooksByCategoryAsync(pageNum, categoryId.Value);    
            
            if (booksCategory.Count() == 0)
            {
                return View("NotFoundBook", new NotFountBookModel("Не удалось найти книгу по категории", categoryName));
            }

            BookListViewModel indexBookModel = new BookListViewModel(pageNum, PageSizes.Books, booksCategory.Count(), booksCategory);

            return View(nameof(IndexBooks), indexBookModel);
        }

        public async Task<IActionResult> IndexBooksByName(string bookName, int pageNum = 1)
        {           
            var books = await _bookService.GetBooksByNameAsync(pageNum, bookName);

            if (books.Count() == 0)
            {
                return View("NotFoundBook", new NotFountBookModel("Не удалось найти книгу по названию", bookName));
            }

            BookListViewModel indexBookModel = new BookListViewModel(pageNum, PageSizes.Books, books.Count(), books);

            return View(nameof(IndexBooks), indexBookModel);           
        }        
    }
}