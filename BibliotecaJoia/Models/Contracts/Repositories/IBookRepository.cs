using BibliotecaJoia.Models.Dtos;

namespace BibliotecaJoia.Models.Contracts.Repositories
{
    public interface IBookRepository
    {
        void Create(BookDto bookDto);
        List<BookDto> ToListBooks();
        BookDto ReadById(string id);
        void Update(BookDto book);
    }
}
