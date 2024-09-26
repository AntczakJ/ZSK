namespace _2_dziedziczenie__kompozycja
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }


    }
    public class Author : Person
    {
        public List<Book> BooksList { get; set; }
        public Author(string firstName, string lastName) : base(firstName, lastName)
        {
            BooksList = new List<Book>();
        }

        public void AddBook(Book book)
        {
            BooksList.Add(book);
        }
    }

    public class Book
    {

        public string Title { get; set; }
        public int PublicationYear { get; set; }
        public Author Author { get; set; }

        public Book(string title, int publicationYear, Author author)
        {
            Title = title;
            PublicationYear = publicationYear;
            Author = author;
        }
    }

    public class Reader : Person
    {
        public List<Book> BorrowedBooksList { get; set; }

        public Reader(string firstName, string lastName) : base(firstName, lastName)
        {
            BorrowedBooksList = new List<Book>();
        }
        public void BorrowedBook(Book book)
        {
            BorrowedBooksList.Add(book);
            Console.WriteLine($"{FirstName} {LastName} wypożyczył książkę {book.Title}");
        }


        public class Library
        {
            public List<Book> BookList { get; set; }
            public List<Reader> ReaderList { get; set; }

            public Library()
            {
                BookList = new List<Book>();
                ReaderList = new List<Reader>();
            }

            public void AddBook(Book book)
            {
                BookList.Add(book);
                Console.WriteLine($"Dodano książkę {book.Title}");
            }

            public void AddReader(Reader reader)
            {
                ReaderList.Add(reader);
                Console.WriteLine($"Dodano czytelnika {reader.FirstName}, {reader.LastName}");
            }
            public void BorrowBook(Reader reader, Book book)
            {
                if (BookList.Contains(book))
                {
                    reader.BorrowedBook(book);
                    BookList.Remove(book);
                    Console.WriteLine($"Książka {book.Title} została dodana do wypożyczonych");
                }
                else
                {
                    Console.WriteLine("Książka jest niedostępna");
                }
            }
        }



        internal class Program
        {
            static void Main(string[] args)
            {
                Author author = new Author("Adam", "Mickiewicz");
                Book book = new Book("Pan Tadeusz", 1834, author);
                author.AddBook(book);

                Reader reader = new Reader("Nigha", "Czarnecki");
                Library library = new Library();
                library.AddBook(book);
                library.AddReader(reader);
                library.BorrowBook(reader, book);


            }
        }
    }
}
/*Utwórz klasę Reader, która dziedziczy po klasie Person:
Dodaj właściwość BorrowedBooksList typu List<Book>.
Dodaj konstruktor inicjalizujący pola FirstName, LastName oraz inicjalizujący pustą listę BorrowedBooksList.
Dodaj metodę BorrowBook, która dodaje książkę do listy BorrowedBooksList i wyświetla komunikat o wypożyczeniu książki.

 
 Utwórz klasę Library:
Zdefiniuj dwie właściwości: BooksList (lista książek) oraz ReadersList (lista czytelników).
Zaimplementuj konstruktor:
Konstruktor powinien inicjalizować puste listy BooksList i ReadersList.
Dodaj metodę AddBook:
Metoda powinna przyjmować obiekt typu Book i dodawać go do listy BooksList.
Po dodaniu książki, metoda powinna wyświetlać komunikat z tytułem dodanej książki.
Dodaj metodę AddReader:
Metoda powinna przyjmować obiekt typu Reader i dodawać go do listy ReadersList.
Po dodaniu czytelnika, metoda powinna wyświetlać komunikat z imieniem i nazwiskiem dodanego czytelnika.
Dodaj metodę BorrowBook:
Metoda powinna przyjmować obiekty typu Reader i Book.
Sprawdź, czy książka znajduje się w BooksList.
Jeśli tak, usuń książkę z BooksList, dodaj ją do listy wypożyczonych książek czytelnika i wyświetl komunikat o wypożyczeniu.
Jeśli nie, wyświetl komunikat, że książka nie jest dostępna.*/