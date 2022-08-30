using BibliotecaJoia.Models.Dtos;

namespace BibliotecaJoia.Models.Contracts.Repositories
{
    public interface IBookRepository
    {
        void Create(BookDto bookDto);
        List<BookDto> ToListBooks();
    }
}
