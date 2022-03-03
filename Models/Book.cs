namespace ConsoleApplication2
{
    public class Book
    {
        public string Name;
        public string Author;
        public int PageCount;
        public string Genre;

        public Book(string name, string author, int page_count, string genre)
        {
            Name = name;
            Author = author;
            PageCount = page_count;
            Genre = genre;
        }

        public override string ToString()
        {
            return $"{Name}\n{Author}\n{PageCount}\n{Genre}";
        }
    }
}