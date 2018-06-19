using ConsoleAppSqliteTest.EFClasses;
using ConsoleAppSqliteTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleAppSqliteTest
{
    // на основе http://blog.rniemand.com/getting-started-with-sqlite-and-entity-framework/

    // Install-Package EntityFramework -Version 6.2.0
    // Install-Package System.Data.SQLite -Version 1.0.108
    // Install-Package SQLite.CodeFirst
    class Program
    {
        static void Main(string[] args)
        {
            using (MyContext db = new MyContext())
            {               
                try
                {                    
                    List<Book> books = db.Books.ToList();
                    foreach (Book b in books)
                    {
                        Console.WriteLine(b.Name + " " + b.Author.FirstName + " " + b.Author.LastName);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}