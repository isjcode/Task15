using System;
using System.Collections.Generic;

namespace ConsoleApplication2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Book book = new Book("Salam", "Ismayil J", 32, "Fiction");
            ILibraryManager library = new ILibraryManager();
            library.Add(book);
            foreach (Book b in library.Filter("dsa", "Fiction"))
            {
               Console.WriteLine(b); 
            }
        }
    }
}