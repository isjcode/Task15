using System;
using System.Collections.Generic;

namespace ConsoleApplication2
{
    public class ILibraryManager
    {
        public static  List<Book> Books = new List<Book>();

        public void Add(Book book)
        {
            if (Books.Find(name => name.Name == book.Name) != null)
            {
                throw new SameBookalreadyAddedExpection();
            }
            Books.Add(book);
        }

        public void ShowInfo(string name)
        {
            Book book = Books.Find(b => b.Name == name);

            if (book != null)
            {
                Console.WriteLine(book);
                return;
            }
            throw new BookNotFoundException();
        }

        public List<Book> Search(string value)
        {
            List<Book> ret = Books.FindAll(b => b.ToString().Contains(value));
            if (ret.Count == 0)
            {
                throw new BookNotFoundException();
            }
            return ret;
        }

        public List<Book> Filter(string author, string genre)
        {
            List<Book> ret = Books.FindAll(b => b.Author == author || b.Genre == genre);
            
            if (ret.Count == 0)
            {
                throw new BookNotFoundException();
            }

            return ret;
        }
    }
}