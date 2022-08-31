using BibliotecaJoia.Models.Contracts.Repositories;
using BibliotecaJoia.Models.Dtos;

namespace BibliotecaJoia.Models.Repositories
{
    public class BookRepository : IBookRepository
    {
        public void Create(BookDto book)
        {
            ContextDataFake.Books.Add(book);
        }

        public BookDto ReadById(string id)
        {
            var book = ContextDataFake.Books.FirstOrDefault(x => x.Id.Equals(id));
            return book;
        }

        public List<BookDto> ToListBooks()
        {
            var books = ContextDataFake.Books;

            return books.OrderBy(b => b.Name).ToList();
        }

        public void Update(BookDto book)
        {
            var result = ReadById(book.Id);
            ContextDataFake.Books.Remove(result);

            //result.Id = book.Id;
            result.Name = book.Name;
            result.Author = book.Author;
            result.Publisher = book.Publisher;

            Create(book);
        }
    }
}
