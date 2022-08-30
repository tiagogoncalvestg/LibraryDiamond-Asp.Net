namespace BibliotecaJoia.Models.Entities
{
    public abstract class BaseEntity
    {
        public string Id { get; set; }

        public BaseEntity()
        {
            Id = Guid.NewGuid().ToString();
        }
    }
}
