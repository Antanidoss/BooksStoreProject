﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using BooksStore.Core.AuthorModel;
using BooksStore.Core.BookModel;
using BooksStore.Core.CategoryModel;
using BooksStore.Core.ImageModel;
using BooksStore.Service.Interfaces;
using BooksStore.Web.Cache;
using BooksStore.Web.Interface.Converter;
using BooksStore.Web.Interfaces;
using BooksStore.Web.Models.CreateModels.Book;
using BooksStore.Web.Models.ViewModels.Book;
using BooksStore.Web.Models.ViewModels.Index;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace BooksStore.Web.Controllers
{
    public class BookController : Controller
    {
        public IBookService BookService { get; set; }
        public IMemoryCache Cache { get; set; }
        public IBookConverter BookConverter { get; set; }
        public IWebHostEnvironment AppEnvironment { get; set; }
        public ICurrentUser CurrentUser { get; set; }

        public BookController(IBookService bookService, IMemoryCache cache, IBookConverter bookConverter, IWebHostEnvironment appEnvironment,
            ICurrentUser currentUser)
        {
            BookService = bookService;
            Cache = cache;
            BookConverter = bookConverter;
            AppEnvironment = appEnvironment;
            CurrentUser = currentUser;
        }

        public async Task<IActionResult> IndexBooks(int pageNum = 1, IndexViewModel<BookViewModel> indexBookModel = null)
        {
            if (pageNum >= 1)
            {
                if (indexBookModel?.Objects == null)
                {
                    int pageSize = 6;                                        
                                            
                    indexBookModel = new IndexViewModel<BookViewModel>(pageNum, pageSize, await BookService.GetCountBooks(),
                        BookConverter.ConvertToBookViewModel(await BookService.GetBooks((pageNum - 1) * pageSize , pageSize)));
                }

                if (HttpContext.User.Identity.IsAuthenticated && indexBookModel.Objects != null && indexBookModel.Objects.Count() != 0)
                {
                    int basketId = (await CurrentUser.GetCurrentAppUser(HttpContext)).BasketId;

                    foreach (var book in indexBookModel.Objects)
                    {
                        if (await BookService.IsBookInBasketAsync(basketId, book.Id))
                        {
                            book.IsAddToBasket = true;
                        }
                    }
                }

                return View(indexBookModel);
            }

            return BadRequest("Некорректные данные в запросе");
        }


        [HttpGet]
        public async Task<IActionResult> IndexBook(int? bookId)
        {
            if (bookId.HasValue)
            {
                if (!Cache.TryGetValue(CacheKeys.GetBookKey(bookId.Value), out Book book))
                {
                    book = await BookService.GetBookByIdAsync(bookId.Value);
                    if (book != null)
                    {
                        Cache.Set(CacheKeys.GetBookKey(bookId.Value), book, new MemoryCacheEntryOptions
                        {
                            AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(CacheTime.GetBookCacheTime())
                        });
                    }
                    else
                    {
                        return NotFound();
                    }
                }

                var bookViewModel = BookConverter.ConvertToBookViewModel(book);

                if (HttpContext.User.Identity.IsAuthenticated)
                {
                    int basketId = (await CurrentUser.GetCurrentAppUser(HttpContext)).BasketId;
                    if (await BookService.IsBookInBasketAsync(basketId, bookId.Value))
                    {
                        bookViewModel.IsAddToBasket = true;
                    }
                }

                return View(bookViewModel);
            }
            return NotFound();
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
        public async Task<IActionResult> AddBook(BookCreateModel createModel, [Required(ErrorMessage = "Выберите изображения")] IFormFile uploadedFile)
        {
            if (ModelState.IsValid)
            {
                string path = "/img/" + uploadedFile.FileName;
                using (var fileStream = new FileStream(AppEnvironment.WebRootPath + path, FileMode.Create))
                {
                    await uploadedFile.CopyToAsync(fileStream);
                }

                await BookService.AddBookAsync(new Book()
                {
                    Title = createModel.Title,
                    Descriptions = createModel.Descriptions,
                    Price = createModel.Price,
                    InStock = createModel.InStock,
                    Category = new Category() { Name = createModel.CategoryName },
                    NumberOfPages = createModel.NumberOfPages,
                    Author = new Author() { FirstName = createModel.FirstNameAuthor, Surname = createModel.SurnameAuthor },
                    Img = new Img() { Path = path }
                });

                return RedirectToAction(nameof(IndexBooksAdmin), "Book");
            }
            return View(createModel);
        }


        [Authorize(Roles = "admin")]
        [HttpGet]
        public async Task<IActionResult> RemoveBook(int? bookId)
        {
            if (bookId.HasValue)
            {
                await BookService.RemoveBookAsync(bookId.Value);          
                RemoveBookInCahe(bookId.Value);

                return RedirectToAction(nameof(IndexBooksAdmin), "Book");
            }
            return View(StatusCode(404));
        }


        [Authorize(Roles = "admin")]
        [HttpGet]
        public async Task<IActionResult> UpdateBook(int? bookId)
        {
            Book updateBook = new Book();
            if (bookId.HasValue && (updateBook = await BookService.GetBookByIdAsync(bookId.Value)) != null)
            {
                View(BookConverter.ConvertToBookViewModel(updateBook));
            }
            return NotFound();
        }

        [Authorize(Roles = "admin")]
        [HttpPost]
        public async Task<IActionResult> UpdateBook(BookViewModel model)
        {
            if (model != null)
            {
                Book updateBook = await BookService.GetBookByIdAsync(model.Id);
                if (updateBook != null)
                {
                    updateBook.Title = model.Title;
                    updateBook.Descriptions = model.Descriptions;
                    updateBook.Price = model.Price;
                    updateBook.NumberOfPages = model.NumberOfPages;
                    updateBook.InStock = model.InStock;
                    updateBook.UpdateTime = DateTime.Now;

                    await BookService.UpdateBookAsync(updateBook);

                    RemoveBookInCahe(updateBook.Id);
                }
                return RedirectToAction("IndexBooksAdmin", "Book");
            }

            return NotFound();
        }

        [HttpGet]
        public async Task<IActionResult> IndexByCategory(int? categoryId, int pageNum = 1)
        {
            if (categoryId.HasValue && pageNum >= 1)
            {
                int pageSize = 6;

                if (!Cache.TryGetValue(CacheKeys.GetBooksByCategoryKey(categoryId.Value), out IEnumerable<Book> booksCategory))
                {
                    booksCategory = await BookService.GetBookByCategoryAsync(categoryId.Value);
                    if(booksCategory.Count() != 0)
                    {
                        Cache.Set(CacheKeys.GetBooksByCategoryKey(categoryId.Value), booksCategory, new MemoryCacheEntryOptions
                        {
                            AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(CacheTime.GetBooksByCategoryCacheTime())
                        });
                    }                   
                }

                IndexViewModel<BookViewModel> indexBookModel = new IndexViewModel<BookViewModel>(pageNum, pageSize, booksCategory.Count()
                    ,BookConverter.ConvertToBookViewModel(booksCategory));

                return View(indexBookModel);
            }

            return NotFound();
        }


        public async Task<IActionResult> IndexBooksByName(string bookName, int pageNum = 1)
        {
            if(!string.IsNullOrEmpty(bookName) && pageNum >= 1)
            {
                int pageSize = 6;
                var books = (await BookService.GetBooks((pageNum - 1) * pageSize, pageSize)).Where(p => p.Title == bookName);

                IndexViewModel<BookViewModel> indexBookModel = new IndexViewModel<BookViewModel>(pageNum, pageSize, books.Count(),
                    BookConverter.ConvertToBookViewModel(books));

                return View(indexBookModel);
            }

            return BadRequest("Некорректные данные в запросе");
        }


        private void RemoveBookInCahe(int bookId)
        {
            if (Cache.TryGetValue(CacheKeys.GetBookKey(bookId), out Book book))
            {
                Cache.Remove(CacheKeys.GetBookKey(bookId));
            }
        }
    }
}