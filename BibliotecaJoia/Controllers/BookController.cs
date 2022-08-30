using BibliotecaJoia.Models.Contracts.Services;
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
    }
}
