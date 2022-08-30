using BibliotecaJoia.Models.Dtos;

namespace BibliotecaJoia.Models.Contracts.Services
{
    public interface IBookService
    {
        List<BookDto> ToListBooks();
    }
}
