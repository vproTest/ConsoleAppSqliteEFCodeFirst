using System.Collections.Generic;

namespace ConsoleAppSqliteTest.Models
{
    public class Author
    {
        public Author()
        {
            this.Books = new List<Book>();
        }

        public long ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual ICollection<Book> Books { get; set; }
    }
}