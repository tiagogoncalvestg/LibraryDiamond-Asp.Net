using BibliotecaJoia.Models.Contracts.Services;
using BibliotecaJoia.Models.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace BibliotecaJoia.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookService _bookService;

        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult List()
        {            
            try
            {
                var books = _bookService.ToListBooks();
                return View(books);
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Name, Author, Publisher")]BookDto book)
        {
            try
            {
                _bookService.Create(book);
                return RedirectToAction("list");
            }catch(Exception e)
            {
                throw e;
            }
            
        }
        public IActionResult Edit(string? id)
        {
            if (string.IsNullOrEmpty(id))
                return NotFound();

            var book = _bookService.ReadById(id);
            if (book == null)
                return NotFound();

            return View(book);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit([Bind("Id, Name, Author, Publisher")]BookDto book)
        {
            if (string.IsNullOrEmpty(book.Id))
                return NotFound();

            try
            {
                _bookService.Update(book);
                return RedirectToAction("List");
            }
            catch(Exception e)
            {
                throw e;
            }

            return View();
        }
    }
}
