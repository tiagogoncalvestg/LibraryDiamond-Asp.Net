namespace BibliotecaJoia.Models.Dtos
{
    public class BookDto
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }

        public BookDto(string id, string name, string author, string publisher) 
            : this(name, author, publisher)
        {
            Id = id;
        }
        public BookDto(string name, string author, string publisher)
        {
            Name = name;
            Author = author;
            Publisher = publisher;
        }
    }
}
