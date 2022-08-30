using BibliotecaJoia.Models.Dtos;

namespace BibliotecaJoia.Models.Repositories
{
    public static class ContextDataFake
    {
        public static List<BookDto> Books = new();

        static ContextDataFake()
        {
            InitializeData();
        }

        public static void InitializeData()
        {
            var book = new BookDto("Tudo sobre DDD", "Richard R. R.", "Altari");
            Books.Add(book);

            book = new BookDto("Ti para leigos", "Lucy Alq.", "Tecnos");
            Books.Add(book);
            
            book = new BookDto("Como treinar seu cachorro", "São Bernardo Terra Nova", "Rocco");
            Books.Add(book);

            book = new BookDto("DC > Marvel", "Lex Luthor", "Obvius");
            Books.Add(book);

            book = new BookDto("POO, do 0 ao Pro!", "Luiz Fonseca", "Maddara Pub");
            Books.Add(book);
        }
    }
}
