namespace ConsoleAppSqliteTest.Models
{
    public class Book
    {       
        public long Id { get; set; }
        public string Name { get; set; }
        public long AuthorId { get; set; }
        public virtual Author Author { get; set; }
    }
}