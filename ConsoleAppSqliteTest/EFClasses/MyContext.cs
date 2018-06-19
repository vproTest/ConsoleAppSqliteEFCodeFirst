using ConsoleAppSqliteTest.Models;
using System.Data.Entity;

namespace ConsoleAppSqliteTest.EFClasses
{
    public class MyContext : DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public MyContext() : base("MyContext")
        {}
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer(new LibInitializer(modelBuilder));    
        }
    }
}