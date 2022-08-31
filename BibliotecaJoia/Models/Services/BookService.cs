using BibliotecaJoia.Models.Contracts.Repositories;
using BibliotecaJoia.Models.Contracts.Services;
using BibliotecaJoia.Models.Dtos;
using BibliotecaJoia.Models.Repositories;

namespace BibliotecaJoia.Models.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;
        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public void Create(BookDto book)
        {
            try
            {
                _bookRepository.Create(book);
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        public BookDto ReadById(string id)
        {
            try
            {
                var result = _bookRepository.ReadById(id);
                return result;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public List<BookDto> ToListBooks()
        {
            try
            {
                return _bookRepository.ToListBooks();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Update(BookDto book)
        {
            try
            {
                _bookRepository.Update(book);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
