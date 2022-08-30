using BibliotecaJoia.Models.Dtos;

namespace BibliotecaJoia.Models.Contracts.Repositories
{
    public interface IBookRepository
    {
        List<BookDto> ToListBooks();
    }
}
