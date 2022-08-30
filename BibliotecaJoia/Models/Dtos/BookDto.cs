using BibliotecaJoia.Models.Entities;

namespace BibliotecaJoia.Models.Dtos
{
    public class BookDto : BaseEntity
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }

        public BookDto()
        {

        }

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
