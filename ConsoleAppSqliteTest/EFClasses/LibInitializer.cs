using ConsoleAppSqliteTest.Models;
using SQLite.CodeFirst;
using System.Data.Entity;

namespace ConsoleAppSqliteTest.EFClasses
{
    public class LibInitializer : // или, при необходимости SqliteDropCreateDatabaseAlways<MyContext>
        SqliteDropCreateDatabaseWhenModelChanges<MyContext>
    {
        public LibInitializer(DbModelBuilder modelBuilder) : base(modelBuilder)
        {
        }
        protected override void Seed(MyContext context)
        {
            Author author1 = new Author { FirstName = "Михаил", LastName = "Булгаков" };
            context.Authors.Add(author1);
            context.SaveChanges();

            Book book1 = new Book { Name = "Мастер и Маргарита", Author = author1 };
            context.Books.Add(book1);
            context.SaveChanges();          
        }
    }
}