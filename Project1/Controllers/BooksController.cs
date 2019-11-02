using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project1.Data;
using Project1.Models.Books;

namespace Project1.Controllers
{
    public class BooksController : Controller
    {
        private readonly BooksContext _dbContext;

        public BooksController(BooksContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IActionResult> Index()
        {
            var books = await _dbContext.Books.ToListAsync();
            return View(books);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(Book book)
        {


            _dbContext.Books.Add(book);
            await _dbContext.SaveChangesAsync();

            var books = await _dbContext.Books.ToListAsync();

            return View("Index", books);
        }

        public async Task<IActionResult> Search(string text)
        {
            text = text.ToLower();
            var searchedBooks = await _dbContext.Books.Where(book => book.Name.ToLower().Contains(text)
                                            || book.Genre.ToLower().Contains(text)
                                            || book.Author.ToLower().Contains(text))
                                        .ToListAsync();
            return View("Index", searchedBooks);
        }

    }
}