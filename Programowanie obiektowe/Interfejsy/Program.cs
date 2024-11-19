namespace Interfejsy
{
    internal class Program
    {
        class Book : IComparable<Book> 
        {
            public string Title;
            public string Author;
            public int YearOfPublic;
            public double Price;
            public Book(string title, string author, int yearOfPublic, double price)
            {
                Title = title;
                Author = author;
                YearOfPublic = yearOfPublic;
                Price = price;
            }

            public override string ToString()
            {
                return $"Title: {Title}, author: {Author}, Year of publication: {YearOfPublic}, price {Price}";
            }

            public int CompareTo(Book? other)
            {
                if(other == null) return 1 ;
                return Price.CompareTo(other.Price) ;
            }
        }

        static void Main(string[] args)
        {
            List<Book> Books = new List<Book>();
            Books.Add(new Book("Hobbit", "Tolkien", 1937, 45.99));
            Books.Add(new Book("Hobbit2", "Tolkien", 1938, 45.99));
            Books.Add(new Book("Hobbit3", "Tolkien", 1939, 45.99));
            Books.Add(new Book("Hobbit4", "Tolkien", 1940, 45.99));
            Console.WriteLine("Lista książek");
            foreach (Book book in Books)
            {
                Console.WriteLine(book.ToString());
            }

            Books.Sort();

            Console.WriteLine("\n\nPosortowana lista wg ceny");
            foreach (Book book in Books)
            {
                Console.WriteLine(book.ToString());
            }
            Console.WriteLine("\n\nPosortowana lista wg daty");
            
            var sortedByYear = Books.OrderBy(b => b.YearOfPublic);
            foreach (Book book in sortedByYear)
            {
                Console.WriteLine(book.ToString());
            }

            Console.WriteLine("\n\nPosortowana lista wg autora");

            var sortedByAuthor = Books.OrderByDescending(b => b.Author);
            foreach (Book book in sortedByAuthor)
            {
                Console.WriteLine(book.ToString());
            }

            Console.WriteLine("\n\nPosortowana lista wg ceny nierosnąco i roku od najstarszej");

            var sortedByPandY = Books.OrderByDescending(b => b.Price).ThenBy(b =>b.YearOfPublic);
            foreach (Book book in sortedByPandY)
            {
                Console.WriteLine(book.ToString());
            }
        }
    }
}
