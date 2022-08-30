using BibliotecaJoia.Models.Contracts.Repositories;
using BibliotecaJoia.Models.Dtos;

namespace BibliotecaJoia.Models.Repositories
{
    public class BookRepository : IBookRepository
    {
        public List<BookDto> ToListBooks()
        {
            var books = ContextDataFake.Books;

            return books.OrderBy(b => b.Name).ToList();
        }
    }
}
